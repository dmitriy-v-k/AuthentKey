namespace AuthentKey
{
    public interface IAuthentication
    {
        IAuthenticationResult CheckAccess(string clientKey, string clientHost);
    }
}