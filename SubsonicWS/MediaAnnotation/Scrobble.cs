using SubsonicWS.Common;
using System.Xml.Serialization;

namespace SubsonicWS.MediaAnnotation
{
    // TODO : implement scrobble
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Scrobble : Response<Scrobble>
    {
    }
}