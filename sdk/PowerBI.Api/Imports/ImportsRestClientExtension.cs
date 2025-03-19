using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Specialized;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    /// <summary>
    /// Client wrapper for Power BI Imports REST Api
    /// </summary>
    internal partial class ImportsRestClient
    {
        private const int MB = 1024 * 1024;
        // We'll use a buffer of 400 MB to reduce the number of API calls
        private const int maxBlockSize = 400 * MB;

        /// <summary>
        /// Uploads a PBIX file to the specified group
        /// </summary>
        /// <param name="groupId">The group Id</param>
        /// <param name="file">The PBIX file to import</param>
        /// <param name="datasetDisplayName">The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business.</param>
        /// <param name="nameConflict">Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options.</param>
        /// <param name="skipReport">Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files.</param>
        /// <param name="overrideReportLabel">Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`.</param>
        /// <param name="overrideModelLabel">Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`.</param>
        /// <param name="subfolderObjectId">The subfolder ID to import the file to subfolder.</param>
        /// <param name="cancellationToken">The cancellation token to use.</param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        internal async Task<Response<Import>> UploadFileAsync(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            if (file == null || datasetDisplayName == null)
            {
                throw new ArgumentNullException(file == null ? nameof(file) : nameof(datasetDisplayName));
            }


            using var message = await CreateUploadFileRequestAsync(groupId, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId);
            await _pipeline.SendAsync(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    {
                        Import value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Import.DeserializeImport(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        private async Task<HttpMessage> CreateUploadFileRequestAsync(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict, bool? skipReport, bool? overrideReportLabel, bool? overrideModelLabel, Guid? subfolderObjectId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;

            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath(groupId != null ? $"v1.0/myorg/groups/{groupId}/imports" : "/v1.0/myorg/imports", false);
            uri.AppendQuery("datasetDisplayName", datasetDisplayName, true);
            if (nameConflict != null)
            {
                uri.AppendQuery("nameConflict", nameConflict.Value.ToSerialString(), true);
            }
            if (skipReport != null)
            {
                uri.AppendQuery("skipReport", skipReport.Value, true);
            }
            if (overrideReportLabel != null)
            {
                uri.AppendQuery("overrideReportLabel", overrideReportLabel.Value, true);
            }
            if (overrideModelLabel != null)
            {
                uri.AppendQuery("overrideModelLabel", overrideModelLabel.Value, true);
            }
            if (subfolderObjectId != null)
            {
                uri.AppendQuery("subfolderObjectId", subfolderObjectId.Value, true);
            }

            request.Uri = uri;
            request.Headers.Add("Content-Type", "multipart/form-data");
            request.Headers.Add("Accept", "application/json");

            // Multipart form data
            var multipartContent = new System.Net.Http.MultipartFormDataContent();

            var streamContent = new StreamContent(file);
            multipartContent.Add(streamContent);
            using (var ms = new MemoryStream())
            {
                await multipartContent.CopyToAsync(ms);
                byte[] formDataAsBytes = ms.ToArray();
                request.Content = RequestContent.Create(formDataAsBytes);
            }

            return message;
        }

        /// <summary>
        /// Uploads a PBIX large file to the specified group
        /// </summary>
        /// <param name="groupId">The group Id</param>
        /// <param name="file">The PBIX file to import</param>
        /// <param name="datasetDisplayName">The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business.</param>
        /// <param name="client"> The Power BI Client</param>
        /// <param name="nameConflict">Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options.</param>
        /// <param name="skipReport">Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files.</param>
        /// <param name="overrideReportLabel">Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`.</param>
        /// <param name="overrideModelLabel">Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`.</param>
        /// <param name="subfolderObjectId">The subfolder ID to import the file to subfolder.</param>
        /// <param name="cancellationToken">optional cancellation token</param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Dataset.ReadWrite.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        internal async Task<Response<Import>> UploadLargeFile(Guid? groupId, Stream file, string datasetDisplayName, PowerBIClient client, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            TemporaryUploadLocation temporaryUploadLocation;

            if (groupId == null)
            {
                temporaryUploadLocation = client.Imports.CreateTemporaryUploadLocation();
            }
            else
            {
                temporaryUploadLocation = client.Imports.CreateTemporaryUploadLocationInGroup(groupId.Value);
            }

            if (temporaryUploadLocation == null || string.IsNullOrEmpty(temporaryUploadLocation.Url))
            {
                throw new Exception("Create temporary upload location step failed");
            }

            await UploadFileToBlob(temporaryUploadLocation.Url, file, cancellationToken);

            if (Path.GetExtension(datasetDisplayName) == string.Empty)
            {
                datasetDisplayName = Path.GetFileNameWithoutExtension(datasetDisplayName) + ".pbix";
            }

            if (groupId == null)
            {
                return await client.Imports.PostImportAsync(datasetDisplayName, new ImportInfo { FileUrl = temporaryUploadLocation.Url }, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId);
            }
            else
            {
                return await client.Imports.PostImportInGroupAsync(groupId.Value, datasetDisplayName, new ImportInfo { FileUrl = temporaryUploadLocation.Url }, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId);
            }
        }

        /// <summary>
        /// Uploads a file in chunks to an temporary upload location location using a block blob client.
        /// </summary>
        /// <param name="temporaryUploadLocationUrl"> The URL of the temporary upload location in Azure Blob Storage. </param>
        /// <param name="file">The PBIX file to import</param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        private async Task UploadFileToBlob(string temporaryUploadLocationUrl, Stream file, CancellationToken cancellationToken)
        {
            var blockBlobClient = new BlockBlobClient(new Uri(temporaryUploadLocationUrl)); //Refer to the https://learn.microsoft.com/en-us/dotnet/api/azure.storage.blobs.specialized.blockblobclient?view=azure-dotnet for creating the block blob client

            List<string> blockIds = new List<string>();
            // We'll use a buffer of 400 MB to reduce the number of API calls
            const int maxBlockSize = 400 * MB;
            byte[] buffer = new byte[maxBlockSize];
            int bytesRead;

            while ((bytesRead = await file.ReadAsync(buffer, 0, maxBlockSize)) > 0)
            {
                // Generate a unique, Base64-encoded block ID to conform to Azure.Storage.Blob's requirement for block IDs.
                string blockId = Convert.ToBase64String(Encoding.UTF8.GetBytes($"block-{Guid.NewGuid()}"));
                blockIds.Add(blockId);

                using (MemoryStream blockData = new MemoryStream(buffer, 0, bytesRead))
                {
                    await blockBlobClient.StageBlockAsync(blockId, blockData);
                }
            }

            await blockBlobClient.CommitBlockListAsync(blockIds);
        }
    }

}
