# Migration Guide: v4.22 to v5

Follow these steps and examples to migrate your application smoothly from version `v4.22` to `v5`.

---

## Breaking Changes
- **Authentication Updates**  
Replace the previously used `Microsoft.Rest.ClientRuntime.Properties` credential package with the `Azure.Identity` package for authentication.

   **Username Password Authentication**:
   ```C#
    var credentials = new UsernamePasswordCredential("username", "password", "tenantID", "ClientId");

    PowerBIClient client = new PowerBIClient(credentials);
   ```
   For further refernce, refer to the [UsernamePasswordCredential](https://learn.microsoft.com/en-us/dotnet/api/azure.identity.usernamepasswordcredential?view=azure-dotnet)  

   **Service Prinicipal Authentication**:
   ```C#
    var credentials = new ClientSecretCredential("tenantId", "clientId", "clientSecret");

    PowerBIClient client = new PowerBIClient(credentials);
   ```
   For further reference, refer to the [ClientSecretCredential](https://learn.microsoft.com/en-us/dotnet/api/azure.identity.clientsecretcredential?view=azure-dotnet)  
   ___
- **Read-Only Property Access**  
In version `v5`, some properties that could previously be modified now been marked as **read-only**. As a result, direct assignment to these properties will throw an error similar to:
Property or indexer '<Property>' cannot be assigned to -- it is read only.  

  Use the `Add` method.  

   **Refer to the code example with v5 package for intializing the required workspaces:**
   ```C#
   using (PowerBIClient client = new PowerBIClient(credentials or Microsoft Entra Access Token))
   {
     var workspaces = new RequiredWorkspaces();
     workspaces.Workspaces.Add(groupId);
     var workspaceInfo = client.WorkspaceInfo.PostWorkspaceInfo(workspaces);
   }
   ```
   ___
-  **Gateway - Create Datasource**:  
    Creates a new data source on the specified on-premises gateway. It supports only on-premises gateways, and the user must have gateway admin permissions.  
    In version `v5`, the `GatewayPublicKey` class now has **internal constructors**. As a result, you can no longer directly instantiate the `GatewayPublicKey` class using its constructor. Instead, you must use the **factory method** provided by the SDK.  

    **Refer to the code example with v5 package for creating a new data source:**

    ```C#
    using (PowerBIClient client = new PowerBIClient(credentials or Microsoft Entra Access Token))
    {
        var basicCredentials = new BasicCredentials(username: "username", password: "password");

        var publicKey = MicrosoftPowerBIApiModelFactory.GatewayPublicKey(
            exponent: "Exponent of the gateway public key",
            modulus: "Modulus of the gateway public key"
        );

        var credentialsEncryptor = new AsymmetricKeyEncryptor(publicKey);

        var credentialDetails = new CredentialDetails(
            basicCredentials,
            CredentialType.Basic,
            PrivacyLevel.None,
            EncryptedConnection.Encrypted,
            credentialsEncryptor
        );

        var pdtgateway = new PublishDatasourceToGatewayRequest(
            dataSourceType: "SQL",
            connectionDetails: JsonConvert.SerializeObject(new
            {
                server = "Server name",
                database = "Database name"
            }),
            credentialDetails: credentialDetails,
            dataSourceName: "SampleDataSource"
        );

        var newDataSource = client.Gateways.CreateDatasource(gatewayId, pdtgateway);
    }
    ```
