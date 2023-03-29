namespace Marketify.Application.Features.Commands.Users.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        private readonly IUserService _userService;

        public UpdatePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            if (!request.Password.Equals(request.PasswordConfirm))
                throw new PasswordChangeFailedException("Please verify the password exactly.");

            await _userService.UpdatePasswordAsync(request.UserId, request.ResetToken, request.Password);
            return new();
        }
    }
}
