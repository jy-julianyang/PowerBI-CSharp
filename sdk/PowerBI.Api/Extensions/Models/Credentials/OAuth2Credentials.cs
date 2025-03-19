﻿namespace Microsoft.PowerBI.Api.Models.Credentials
{

    /// <summary>
    /// OAuth2 based datasource credentials using OAuth2 access token
    /// </summary>
    public class OAuth2Credentials : CredentialsBase
    {
        private const string ACCESS_TOKEN = "accessToken";

        internal override CredentialType CredentialType { get => CredentialType.OAuth2; }

        /// <summary>
        /// Initializes a new instance of the OAuth2Credentials class.
        /// </summary>
        /// <param name="accessToken">The access token</param>
        public OAuth2Credentials(string accessToken)
        {

            Argument.AssertNotNullOrEmpty(accessToken, nameof(accessToken));

            this.CredentialData[ACCESS_TOKEN] = accessToken;
        }
    }
}
