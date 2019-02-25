using System;
using System.Collections.Generic;
using System.Text;

namespace AuthentKey
{
    public sealed class AccessKey : IAccessKey
    {
        private readonly string clientKey;
        private readonly string clientHost;

        public AccessKey(string clientKey, string clientHost)
        {
            this.clientKey = clientKey;
            this.clientHost = clientHost;
        }

        public string AsString()
        {
            return clientKey;
        }

        public bool CheckAccess(string clientKey, string clientHost)
        {
            return this.clientKey == clientKey && this.clientHost == clientHost;
        }
    }
}
