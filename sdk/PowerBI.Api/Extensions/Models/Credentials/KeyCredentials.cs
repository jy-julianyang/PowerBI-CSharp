namespace Microsoft.PowerBI.Api.Models.Credentials
{

    /// <summary>
    /// Key based datasource credentials
    /// </summary>
    public class KeyCredentials : CredentialsBase
    {
        private const string KEY = "key";

        internal override CredentialType CredentialType { get => CredentialType.Key; }

        /// <summary>
        /// Initializes a new instance of the KeyCredentials class.
        /// </summary>
        /// <param name="key">The key</param>
        public KeyCredentials(string key)
        {
            Argument.AssertNotNullOrEmpty(key, nameof(key));

            this.CredentialData[KEY] = key;
        }
    }
}
