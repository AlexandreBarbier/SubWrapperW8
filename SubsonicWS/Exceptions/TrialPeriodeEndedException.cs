using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubsonicWS.Exceptions
{
    class TrialPeriodeEndedException : Exception
    {
        

        public TrialPeriodeEndedException(string message)
            :base(message)
        {
        }
    }
}
