using System;

namespace SubsonicWS.Exceptions
{
    public class RatingValueException : Exception
    {
        public RatingValueException(string p)
            : base(p)
        {
        }
    }
}