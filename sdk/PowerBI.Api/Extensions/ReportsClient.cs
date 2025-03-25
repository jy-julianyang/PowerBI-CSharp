using Azure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Microsoft.PowerBI.Api
{
    public partial class ReportsClient
    {
        /// <summary> Returns the file from the [Export to File](/rest/api/power-bi/reports/export-to-file) job for the specified report from **My workspace**. </summary>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual async Task<Response<Stream>> GetFileOfExportToFileAsync(Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReportsClient.GetFileOfExportToFile");
            scope.Start();
            try
            {
                return await RestClient.GetFileOfExportToFileAsync(reportId, exportId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the file from the [Export to File](/rest/api/power-bi/reports/export-to-file) job for the specified report from **My workspace**. </summary>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks>
        /// ## Required Scope
        ///
        /// Report.ReadWrite.All or Report.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        public virtual Response<Stream> GetFileOfExportToFile(Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReportsClient.GetFileOfExportToFile");
            scope.Start();
            try
            {
                return RestClient.GetFileOfExportToFile(reportId, exportId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the file from the [Export to File In Group](/rest/api/power-bi/reports/export-to-file-in-group) job for the specified report from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
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
        public virtual async Task<Response<Stream>> GetFileOfExportToFileInGroupAsync(Guid groupId, Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReportsClient.GetFileOfExportToFileInGroup");
            scope.Start();
            try
            {
                return await RestClient.GetFileOfExportToFileInGroupAsync(groupId, reportId, exportId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the file from the [Export to File In Group](/rest/api/power-bi/reports/export-to-file-in-group) job for the specified report from the specified workspace. </summary>
        /// <param name="groupId"> The workspace ID. </param>
        /// <param name="reportId"> The report ID. </param>
        /// <param name="exportId"> The export ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
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
        public virtual Response<Stream> GetFileOfExportToFileInGroup(Guid groupId, Guid reportId, string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ReportsClient.GetFileOfExportToFileInGroup");
            scope.Start();
            try
            {
                return RestClient.GetFileOfExportToFileInGroup(groupId, reportId, exportId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

    }
}
