using System;
using System.Collections.Generic;
using System.Text;

namespace AuthentKey
{
    public interface IAccessKey
    {
        bool CheckAccess(string clientKey, string clientHost);
        string AsString();
    }
}
