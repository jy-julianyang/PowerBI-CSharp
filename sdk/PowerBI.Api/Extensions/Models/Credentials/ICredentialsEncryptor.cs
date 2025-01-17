using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.PowerBI.Api.Extensions.Models.Credentials
{
    /// <summary>
    /// Interface for encrypting credentials.
    /// </summary>
    public interface ICredentialsEncryptor
    {
        /// <summary>
        /// Encodes the specified plain text credentials.
        /// </summary>
        /// <param name="plainText">The plain text credentials to encode.</param>
        /// <returns>The encoded credentials.</returns>
        string EncodeCredentials(string plainText);
    }
}
