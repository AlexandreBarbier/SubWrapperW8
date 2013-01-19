using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("searchResult")]
    public class SearchResult
    {
        [XmlAttribute("offset")]
        public int Offset { get; set; }

        [XmlAttribute("totalHits")]
        public int TotalHits { get; set; }

        [XmlElement("match")]
        public List<Match> Matches { get; set; }
    }
}