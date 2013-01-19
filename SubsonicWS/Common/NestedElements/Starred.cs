using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("starred")]
    public class Starred
    {
        [XmlElement("artist")]
        public List<Artist> Artists { get; set; }

        [XmlElement("song")]
        public List<Song> Songs { get; set; }

        [XmlElement("album")]
        public List<Album> Albums { get; set; }

        public Starred()
        {
        }
    }
}