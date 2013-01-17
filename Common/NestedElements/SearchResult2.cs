using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("searchResult2")]
    public class SearchResult2
    {
        [XmlElement("album")]
        public List<Album> Albums { get; set; }
        [XmlElement("song")]
        public List<Song> Songs { get; set; }
        [XmlElement("artist")]
        public List<Artist> Artists { get; set; }

        
    }
}
