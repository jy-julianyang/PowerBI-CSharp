# Power BI REST APIs for .NET
## Migration Guide
If you are migrating from version `v4.22` to `v5`, please refer to the [Migration Guide](./Migration.md) for detailed instructions and breaking changes.
## Overview
The Power BI REST APIs provide service endpoints for embedding, user resources management, administration and governance.

For more information about Power BI REST APIs, see [Power BI REST APIs overview](https://docs.microsoft.com/rest/api/power-bi/).

## Power BI API library
The Microsoft.PowerBI.Api library for .NET enables you to work with Power BI REST APIs in your .NET or NET Core application.

Install the [NuGet package](https://www.nuget.org/packages/Microsoft.PowerBI.Api/) directly from the Visual Studio [Package Manager console](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-powershell).

### Visual Studio Package Manager
```powershell
Install-Package Microsoft.PowerBI.Api
```
## Creating the Power BI Client
The `PowerBIClient` can be created using either **credentials** or a **Microsoft Entra Access Token**.

###  Using Credentials
Authenticate by providing service principal `credentials(client ID, client secret, and tenant ID)` or username password `credentials(client ID, tenant ID, username and password )`.  

For more details, see the [Authentication Updates](./Migration.md#authentication-updates) section in the migration guide.


###  Using Microsoft Entra Access Token
Alternatively, authenticate using a Microsoft Entra Access Token for secure, delegated access.
## Examples

Below are basic examples demonstrating some of the most common capabilities of the SDK.
Full examples including authentication are avaliable in [PowerBI-Developer-Samples](https://github.com/Microsoft/PowerBI-Developer-Samples)

### Get the list of datasets and reports in a Power BI workspace
```C#
...
using (PowerBIClient client = new PowerBIClient(credentials or Microsoft Entra Access Token ))
{

    Console.WriteLine("\r*** DATASETS ***\r");

    // List of datasets in a workspace
    Datasets datasets = client.Datasets.GetDatasetsInGroup(groupId);

    foreach(Dataset ds in datasets.Value)
    {
        Console.WriteLine(ds.Id + " | " + ds.Name);
    }

    Console.WriteLine("\r*** REPORTS ***\r");

    // List of reports in a workspace
    Reports reports = client.Reports.GetReportsInGroup(groupId);

    foreach (Report rpt in reports.Value)
    {
        Console.WriteLine(rpt.Id + " | " + rpt.Name +  " | DatasetID = " + rpt.DatasetId);
    }
}
...
```
### Creating an Embed Token to reports and datasets
Embed tokens are used to provide access to Power BI artifacts like reports and datasets to embed into an application.
To create a report embed token you will need a Power BI Embedded capacity, and the Ids of the workspaces and artifacts to provide access to.
For more information about Power BI Embedded visit the [Power BI Embedded Analytics Playground](https://playground.powerbi.com)


```C#
...
using (PowerBIClient client = new PowerBIClient(credentials or Microsoft Entra Access Token))
{
    // Create a request for getting Embed token
     var tokenRequest = new GenerateTokenRequestV2();
     tokenRequest.Datasets.Add(datasets);
     tokenRequest.Reports.Add(reports);
     tokenRequest.TargetWorkspaces.Add(workspaces);
     tokenRequest.Identities.Add(identities);

    // Get Embed token
    var embedToken = client.EmbedToken.GenerateToken(tokenRequest);
}
...
```
### Get Reports As Admin
Returns a list of reports for the organization. The caller must have administrator rights.
```C#
...
using (PowerBIClient client = new PowerBIClient(credentials or Microsoft Entra Access Token))
{
    Console.WriteLine("\r*** REPORTS ***\r");

    // List of reports in the organization.
    AdminReports reports = client.Reports.GetReportsAsAdmin();

    foreach (AdminReport rpt in reports.Value)
    {
        Console.WriteLine(rpt.Id + " | " + rpt.Name);
    }
}
...
```

## Additional links
- [Power BI REST APIs](https://docs.microsoft.com/rest/api/power-bi/)
- [PowerBI-Developer-Samples](https://github.com/Microsoft/PowerBI-Developer-Samples)
- [AAD Application registration](https://docs.microsoft.com/power-bi/developer/embedded/register-app?tabs=customers%2CAzure#register-an-azure-ad-app)
- [Power BI Embedded Analytics Playground](https://playground.powerbi.com)
- [PowerBI Powershell CmdLet](https://github.com/microsoft/powerbi-powershell)
