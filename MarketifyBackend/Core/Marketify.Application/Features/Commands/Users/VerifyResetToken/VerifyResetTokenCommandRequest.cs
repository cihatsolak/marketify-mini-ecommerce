namespace Marketify.Application.Features.Commands.Users.VerifyResetToken
{
    public class VerifyResetTokenCommandRequest : IRequest<VerifyResetTokenCommandResponse>
    {
        public string ResetToken { get; set; }
        public string UserId { get; set; }
    }
}
