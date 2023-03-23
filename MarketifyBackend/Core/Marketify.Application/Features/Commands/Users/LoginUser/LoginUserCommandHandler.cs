namespace Marketify.Application.Features.Commands.Users.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommandRequest, LoginUserCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ITokenHandler _tokenHandler;

        public LoginUserCommandHandler(
            UserManager<AppUser> userManager, 
            SignInManager<AppUser> signInManager, 
            ITokenHandler tokenHandler)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenHandler = tokenHandler;
        }

        public async Task<LoginUserCommandResponse> Handle(LoginUserCommandRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.FindByNameAsync(request.UsernameOrEmail);
            user ??= await _userManager.FindByEmailAsync(request.UsernameOrEmail);

            if (user is null)
                throw new NotFoundUserException("User or password incorrect...");

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if (result.Succeeded)
            {
                Token token = _tokenHandler.CreateAccessToken(5);
                return new LoginUserSuccessCommandResponse()
                {
                    Token = token
                };
            }

            throw new AuthenticationErrorException();
        }
    }
}
