using System;

namespace SubsonicWS.Exceptions
{
    public class InvalidUserNameOrPasswordException : Exception
    {
        public InvalidUserNameOrPasswordException(string message)
            : base(message)
        {
        }
    }
}