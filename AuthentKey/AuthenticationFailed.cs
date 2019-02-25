using System;
using System.Collections.Generic;
using System.Text;

namespace AuthentKey
{
    public sealed class AuthenticationFailed : IAuthenticationResult
    {
        public AuthenticationFailed()
        {
        }

        public string AsString()
        {
            return "Error";
        }
    }
}
