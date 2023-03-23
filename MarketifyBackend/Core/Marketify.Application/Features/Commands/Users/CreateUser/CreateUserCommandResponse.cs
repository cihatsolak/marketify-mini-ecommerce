namespace Marketify.Application.Features.Commands.Users.CreateUser
{
    public class CreateUserCommandResponse
    {
        public CreateUserCommandResponse(bool succeeded)
        {
            Succeeded = succeeded;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
    }
}
