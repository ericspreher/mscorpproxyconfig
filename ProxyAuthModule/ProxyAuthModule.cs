using System;
using System.Net;

namespace ProxyAuthModule
{
    public class AuthProxyModule : IWebProxy
    {
        ICredentials credentials = new NetworkCredential("username", "Password");

        public ICredentials Credentials
        {
            get
            {
                return credentials;
            }
            set
            {
                credentials = value;
            }
        }

        public Uri GetProxy(Uri destination)
        {
            return new Uri("http://proxy.domain.com:8888", UriKind.Absolute);
        }

        public bool IsBypassed(Uri host)
        {
            return host.IsLoopback;
        }

    }
}
