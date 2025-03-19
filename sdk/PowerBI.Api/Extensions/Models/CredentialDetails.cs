namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.PowerBI.Api.Extensions.Models.Credentials;
    using Microsoft.PowerBI.Api.Models.Credentials;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The credential details
    /// </summary>
    public partial class CredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        public CredentialDetails(CredentialsBase credentialsBase, CredentialType credentialType, PrivacyLevel privacyLevel, EncryptedConnection encryptedConnection, ICredentialsEncryptor credentialsEncryptor = null, bool? useEndUserOAuth2Credentials = default(bool?))
            : this(privacyLevel, credentialType,encryptedConnection, credentialsEncryptor, useEndUserOAuth2Credentials)
        {
            var credentials = new CredentialsRequest
            {
                CredentialData = credentialsBase.CredentialData.Select((pair) => new NameValuePair(pair.Key, pair.Value))
            };

            var credentialsJson = JsonConvert.SerializeObject(credentials);

            if (credentialsEncryptor != null)
            {
                credentialsJson = credentialsEncryptor.EncodeCredentials(credentialsJson);
            }

            Credentials = credentialsJson;
            CredentialType = credentialsBase.CredentialType;
        }

        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        protected CredentialDetails(PrivacyLevel privacyLevel, CredentialType credentialType, EncryptedConnection encryptedConnection, ICredentialsEncryptor credentialsEncryptor, bool? useEndUserOAuth2Credentials = default(bool?))
        {
            EncryptedConnection = encryptedConnection;
            EncryptionAlgorithm = credentialsEncryptor != null ? EncryptionAlgorithm.RSAOaep : EncryptionAlgorithm.None;
            PrivacyLevel = privacyLevel;
            CredentialType = credentialType;
            UseCallerAADIdentity = false;
            UseEndUserOAuth2Credentials = useEndUserOAuth2Credentials;
        }
    }

    /// <summary>
    /// The credential details using caller AAD identity as OAuth credentials
    /// </summary>
    public class CredentialDetailsUsingCallerOauthAADIdentity : CredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the UpdateDatasourceRequest class for cloud datasource.
        /// </summary>
        public CredentialDetailsUsingCallerOauthAADIdentity(PrivacyLevel privacyLevel, EncryptedConnection encryptedConnection, bool? useEndUserOAuth2Credentials = default(bool?))
            : base(privacyLevel, CredentialType.OAuth2, encryptedConnection, null, useEndUserOAuth2Credentials)
        {
            UseCallerAADIdentity = true;
        }
    }

    /// <summary>
    /// CredentialsRequest
    /// </summary>
    public class CredentialsRequest
    {
        /// <summary>
        /// Credential Data
        /// </summary>
        [JsonProperty(PropertyName = "credentialData")]
        public IEnumerable<NameValuePair> CredentialData { get; set; }
    }

    /// <summary>
    /// NameValuePair
    /// </summary>
    public class NameValuePair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameValuePair"/> class.
        /// </summary>
        public NameValuePair() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="NameValuePair"/> class with the specified name and value.
        /// </summary>
        /// <param name="name">The name of the pair.</param>
        /// <param name="value">The value of the pair.</param>
        public NameValuePair(string name = default(string), string value = default(string))
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets the name of the pair.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the pair.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }
    }
}
