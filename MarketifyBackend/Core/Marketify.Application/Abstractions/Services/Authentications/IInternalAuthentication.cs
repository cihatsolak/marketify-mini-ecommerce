namespace Marketify.Application.Abstractions.Services.Authentications
{
    public interface IInternalAuthentication
    {
        Task<Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
    }
}
