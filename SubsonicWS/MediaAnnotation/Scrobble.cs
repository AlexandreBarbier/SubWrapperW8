using SubsonicWS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.MediaAnnotation
{
    // TODO : implement scrobble
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Scrobble : Response<Scrobble>
    {
        
    }
}
