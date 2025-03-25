using System;
using System.IdentityModel.Tokens.Jwt;

namespace Microsoft.PowerBI.Api
{
    internal static class PowerBIClientUtils
    {
        #region Argument validation

        public static void AssertNotNull<T>(T value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
        }

        public static void AssertNotNullOrEmpty(string value, string name)
        {
            if (value is null)
            {
                throw new ArgumentNullException(name);
            }
            if (value.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", name);
            }
        }

        public static void AssertValidUriScheme(Uri uri, string name)
        {
            if (uri != null && !uri.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Invalid URI scheme. Scheme must be 'https'.", name);
            }
        }

        #endregion Argument validation

        #region Helpers

        internal static JwtSecurityToken DecodeTokenAndValidate(string accessToken)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken decodedToken = tokenHandler.ReadToken(accessToken) as JwtSecurityToken;
            AssertNotNull(decodedToken, nameof(decodedToken));
            ValidateTokenExpiration(decodedToken);
            return decodedToken;
        }

        /// <summary>
        /// Extract the expiration time in seconds from the payload
        /// </summary>
        internal static DateTimeOffset GetExpirationTime(this JwtSecurityToken decodedToken)
        {
            return new DateTimeOffset(decodedToken.ValidTo);
        }

        #endregion

        #region Private Helpers

        private static void ValidateTokenExpiration(JwtSecurityToken decodedToken)
        {
            var expirationTime = decodedToken.ValidTo;
            var thresholdTime = DateTime.UtcNow.AddMinutes(1);
            if (expirationTime <= thresholdTime)
            {
                throw new ArgumentException("The token is about to expire", "token");
            }
        }

        #endregion
    }
}
