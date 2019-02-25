using System;
using System.Collections.Generic;
using System.Linq;

namespace AuthentKey
{
    public sealed class Authentication : IAuthentication
    {
        private readonly IEnumerable<IAccessKey> keys;

        public Authentication(IEnumerable<IAccessKey> keys)
        {
            this.keys = keys;
        }

        public IAuthenticationResult CheckAccess(string clientKey, string clientHost)
        {
            IAccessKey key = keys.SingleOrDefault(_ => _.CheckAccess(clientKey, clientHost));
            if (key != null)
            {
                return new AuthenticationOK(key.AsString());
            }
            else
            {
                return new AuthenticationFailed();
            }
        }
    }
}
