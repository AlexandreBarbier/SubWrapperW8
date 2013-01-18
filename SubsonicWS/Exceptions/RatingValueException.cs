using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
