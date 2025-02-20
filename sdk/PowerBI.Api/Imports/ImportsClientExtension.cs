using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Microsoft.PowerBI.Api.Models;

namespace Microsoft.PowerBI.Api
{
    /// <summary>
    /// Client wrapper for Power BI Imports REST Api
    /// </summary>
    public partial class ImportsClient
    {

        /// <summary> Initializes a new instance of ImportsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <param name="client"> The Power BI Client. </param>
        public ImportsClient(TokenCredential credential, Uri endpoint = null, PowerBIClientOptions options = null, PowerBIClient client = null) : this(credential, endpoint, options)
        {
            this.client = client;
        }

        private PowerBIClient client = null;

        private const int MB = 1024 * 1024;
        private const int GB = 1024 * MB;

        /// <summary>
        /// Uploads a PBIX file to the MyWorkspace
        /// </summary>
        /// <param name="file"> The PBIX file to import</param>
        /// <param name="datasetDisplayName"> The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business. </param>
        /// <param name="nameConflict"> Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options. </param>
        /// <param name="skipReport"> Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files. </param>
        /// <param name="overrideReportLabel"> Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="overrideModelLabel"> Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="subfolderObjectId"> The subfolder ID to import the file to subfolder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Import> PostImportWithFile(Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            return PostImportWithFileAsyncInGroup(null, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Uploads a PBIX file to the MyWorkspace
        /// </summary>
        /// <param name="file">The PBIX file to import</param>
        /// <param name="datasetDisplayName"> The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business. </param>
        /// <param name="nameConflict"> Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options. </param>
        /// <param name="skipReport"> Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files. </param>
        /// <param name="overrideReportLabel"> Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="overrideModelLabel"> Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="subfolderObjectId"> The subfolder ID to import the file to subfolder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Import>> PostImportWithFileAsync(Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            return await PostImportWithFileAsyncInGroup(null, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken);
        }

        /// <summary>
        /// Uploads a PBIX file to the MyWorkspace
        /// </summary>
        /// <param name="file">The PBIX file to import</param>
        /// <param name='groupId'>The group Id </param>
        /// <param name="datasetDisplayName"> The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business. </param>
        /// <param name="nameConflict"> Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options. </param>
        /// <param name="skipReport"> Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files. </param>
        /// <param name="overrideReportLabel"> Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="overrideModelLabel"> Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="subfolderObjectId"> The subfolder ID to import the file to subfolder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Import> PostImportWithFileInGroup(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            return PostImportWithFileAsyncInGroup(groupId, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Uploads a PBIX file to the MyWorkspace
        /// </summary>
        /// <param name="file">The PBIX file to import</param>
        /// <param name='groupId'>The group Id </param>
        /// <param name="datasetDisplayName"> The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business. </param>
        /// <param name="nameConflict"> Specifies what to do if a dataset with the same name already exists. The default value is `Ignore`. For RDL files, `Abort` and `Overwrite` are the only supported options. </param>
        /// <param name="skipReport"> Whether to skip report import. If specified, the value must be `true`. Only supported for Power BI .pbix files. </param>
        /// <param name="overrideReportLabel"> Whether to override the existing report label when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="overrideModelLabel"> Whether to override the existing label on a model when republishing a Power BI .pbix file. The service default value is `true`. </param>
        /// <param name="subfolderObjectId"> The subfolder ID to import the file to subfolder. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Import>> PostImportWithFileAsyncInGroup(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ImportsClient.PostImportWithFile");
            scope.Start();
            try
            {
                if (file.Length < GB)
                {
                    return await UploadFileAsync(groupId, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken);
                }
                else
                {
                    return await UploadLargeFileAsync(groupId, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken);
                }

            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

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
        private async Task<Response<Import>> UploadFileAsync(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ImportsClient.UploadFile");
            scope.Start();
            try
            {
                return await RestClient.UploadFileAsync(groupId, file, datasetDisplayName, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Uploads a PBIX large file to the specified group
        /// </summary>
        /// <param name="groupId">The group Id</param>
        /// <param name="file">The PBIX file to import</param>
        /// <param name="datasetDisplayName">The display name of the dataset, should include file extension. Not supported when importing from OneDrive for Business.</param>
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
        private async Task<Response<Import>> UploadLargeFileAsync(Guid? groupId, Stream file, string datasetDisplayName, ImportConflictHandlerMode? nameConflict = null, bool? skipReport = null, bool? overrideReportLabel = null, bool? overrideModelLabel = null, Guid? subfolderObjectId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReportsClient.UploadLargeFile");
            scope.Start();
            try
            {
                return await RestClient.UploadLargeFile(groupId, file, datasetDisplayName, client, nameConflict, skipReport, overrideReportLabel, overrideModelLabel, subfolderObjectId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}