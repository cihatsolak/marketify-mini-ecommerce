namespace Marketify.Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly UserManager<AppUser> _userManager;

        public CreateUserCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            AppUser appUser = new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = request.Username,
                Email = request.Email,
                NameSurname = request.NameSurname,
            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, request.Password);

            CreateUserCommandResponse createUserCommandResponse = new(identityResult.Succeeded);

            if (identityResult.Succeeded)
            {
                createUserCommandResponse.Message = "The user has been successfully created.";
                return createUserCommandResponse;
            }

            StringBuilder stringBuilder = new();

            foreach (var error in identityResult.Errors)
            {
                stringBuilder.AppendLine($"{error.Code} - {error.Description}");
            }

            createUserCommandResponse.Message = stringBuilder.ToString();

            return createUserCommandResponse;
        }
    }
}
