namespace Marketify.Application.Abstractions.Tokens
{
    public interface ITokenHandler
    {
        Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
