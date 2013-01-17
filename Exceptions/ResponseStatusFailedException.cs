using SubsonicWS.Common;
using System;

namespace SubsonicWS.Exceptions
{
    public class ResponseStatusFailedException : Exception
    {
        public ResponseError error { get; set; }

        public ResponseStatusFailedException(String message)
            : base(message)
        {
        }

        public ResponseStatusFailedException(String message, ResponseError err)
            : base(message)
        {
            error = err;
        }
    }
}