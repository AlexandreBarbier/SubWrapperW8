﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("searchResult3")]
    public class SearchResult3
    {
        [XmlElement("album")]
        public List<Album> Albums { get; set; }

        [XmlElement("song")]
        public List<Song> Songs { get; set; }

        [XmlElement("artist")]
        public List<Artist> Artists { get; set; }

        public SearchResult3()
        {
        }
    }
}