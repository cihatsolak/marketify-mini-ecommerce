namespace Marketify.Application.Exceptions
{
    public class PasswordChangeFailedException : Exception
    {
        public PasswordChangeFailedException() : base("There was a problem updating the password.")
        {
        }

        public PasswordChangeFailedException(string? message) : base(message)
        {
        }

        public PasswordChangeFailedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
