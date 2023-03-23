namespace Marketify.Application.Abstractions.Services.Authentications
{
    public interface IExternalAuthentication
    {
        Task<Token> FacebookLoginAsync(string authToken, int accessTokenLifeTime);
        Task<Token> GoogleLoginAsync(string idToken, int accessTokenLifeTime);
    }
}
