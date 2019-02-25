using System;
using System.Collections.Generic;
using System.Text;

namespace AuthentKey
{
    public sealed class AuthenticationOK : IAuthenticationResult
    {
        private readonly string tmpKey;

        public AuthenticationOK(string tmpKey)
        {
            this.tmpKey = tmpKey;
        }

        public string AsString()
        {
            return tmpKey;
        }
    }
}
