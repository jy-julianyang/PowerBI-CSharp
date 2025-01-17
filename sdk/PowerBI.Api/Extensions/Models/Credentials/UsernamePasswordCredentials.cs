namespace Microsoft.PowerBI.Api.Models.Credentials
{
    /// <summary>
    /// Username and Password based datasource credentials
    /// </summary>
    public abstract class UsernamePasswordCredentials : CredentialsBase
    {
        private const string USERNAME = "username";
        private const string PASSWORD = "password";

        /// <summary>
        /// Initializes a new instance of the UsernamePasswordCredentials class.
        /// </summary>
        /// <param name="username">The username</param>
        /// <param name="password">The password</param>
        public UsernamePasswordCredentials(string username, string password)
        {
            Argument.AssertNotNullOrEmpty(username, nameof(username));
            Argument.AssertNotNullOrEmpty(password, nameof(password));

            this.CredentialData[USERNAME] = username;
            this.CredentialData[PASSWORD] = password;
        }
    }
}
