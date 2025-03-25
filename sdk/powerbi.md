# Power BI for .NET
> see https://aka.ms/autorest 

## Getting Started 
To build the SDK for PowerBI API, simply install AutoRest via `npm` (`npm install -g autorest`) and then run:
> `autorest powerbi.md`

``` yaml
input-file: swaggers\swagger.json
namespace: Microsoft.PowerBI.Api
csharp: true
output-folder: PowerBI.Api\Source
clear-output-folder: true
override-client-name: PowerBIClient
skip-csproj: true
public-clients: true
generation1-convenience-client: true
security: AADToken
security-scopes: https://analysis.windows.net/powerbi/api/.default
use-extension:
  "@autorest/csharp": "3.0.0-beta.20240813.7"
directive:
    - remove-operation: Reports_GetFileOfExportToFile
    - remove-operation: Reports_GetFileOfExportToFileInGroup
```
