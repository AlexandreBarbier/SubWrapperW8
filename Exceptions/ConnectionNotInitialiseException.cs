using System;

namespace SubsonicWS.Exceptions
{
    internal class ConnectionNotInitialiseException : Exception
    {
        public ConnectionNotInitialiseException(string p)
            : base(p)
        {
        }
    }
}