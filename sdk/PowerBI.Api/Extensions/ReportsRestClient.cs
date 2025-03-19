using Azure.Core;
using Azure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Microsoft.PowerBI.Api
{
    internal partial class ReportsRestClient
    {

        internal HttpMessage CreateGetFileOfExportToFileRequest(Guid reportId, string exportId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/reports/", false);
            uri.AppendPath(reportId, true);
            uri.AppendPath("/exports/", false);
            uri.AppendPath(exportId, true);
            uri.AppendPath("/file", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/*, image/*, text/xml, text/csv, multipart/related");
            return message;
        }

        /// <summary> Returns the file from the [Export to File](/rest/api/power-bi/reports/export-to-file) job for the specified report from **My workspace**. </summary>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<Stream>> GetFileOfExportToFileAsync(Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            using var message = CreateGetFileOfExportToFileRequest(reportId, exportId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        return Response.FromValue(message.Response.ContentStream, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the file from the [Export to File](/rest/api/power-bi/reports/export-to-file) job for the specified report from **My workspace**. </summary>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<Stream> GetFileOfExportToFile(Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            using var message = CreateGetFileOfExportToFileRequest(reportId, exportId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {

                        return Response.FromValue(message.Response.ContentStream, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }


        internal HttpMessage CreateGetFileOfExportToFileInGroupRequest(Guid groupId, Guid reportId, string exportId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/v1.0/myorg/groups/", false);
            uri.AppendPath(groupId, true);
            uri.AppendPath("/reports/", false);
            uri.AppendPath(reportId, true);
            uri.AppendPath("/exports/", false);
            uri.AppendPath(exportId, true);
            uri.AppendPath("/file", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/*, image/*, text/xml, text/csv, multipart/related");
            return message;
        }

        /// <summary> Returns the file from the [Export to File In Group](/rest/api/power-bi/reports/export-to-file-in-group) job for the specified report from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        /// <remarks>
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public async Task<Response<Stream>> GetFileOfExportToFileInGroupAsync(Guid groupId, Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            using var message = CreateGetFileOfExportToFileInGroupRequest(groupId, reportId, exportId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        return Response.FromValue(message.Response.ContentStream, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Returns the file from the [Export to File In Group](/rest/api/power-bi/reports/export-to-file-in-group) job for the specified report from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        /// <remarks>
        /// ## Permissions
        ///
        /// This API call can be called by a service principal profile. For more information see: [Service principal profiles in Power BI Embedded](/power-bi/developer/embedded/embed-multi-tenancy).
        ///
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public Response<Stream> GetFileOfExportToFileInGroup(Guid groupId, Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            using var message = CreateGetFileOfExportToFileInGroupRequest(groupId, reportId, exportId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        return Response.FromValue(message.Response.ContentStream, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }


    }
}
