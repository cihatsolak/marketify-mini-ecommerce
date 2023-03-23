namespace Marketify.Application.Exceptions
{
    public class UserCreateFailedException : Exception
    {
        public UserCreateFailedException() : base("An unexpected error was encountered while creating a user!")
        {
        }

        public UserCreateFailedException(string message) : base(message)
        {
        }

        public UserCreateFailedException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
