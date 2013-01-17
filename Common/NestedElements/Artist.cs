using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("artist")]
    public class Artist
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("albumCount")]
        public int AlbumCount { get; set; }

        [XmlAttribute("coverArt")]
        public String CoverArt { get; set; }

        [XmlElement("album")]
        public List<Album> Albums { get; set; }

        public Artist()
        {
        }
    }
}