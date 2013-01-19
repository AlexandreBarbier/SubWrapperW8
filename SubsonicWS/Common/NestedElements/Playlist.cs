using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("playlist")]
    public class Playlist
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("comment")]
        public String Comment { get; set; }

        [XmlAttribute("owner")]
        public String Owner { get; set; }

        [XmlAttribute("public")]
        public Boolean IsPublic { get; set; }

        [XmlAttribute("songCount")]
        public int SongCount { get; set; }

        [XmlAttribute("duration")]
        public int Duration { get; set; }

        [XmlAttribute("created")]
        public DateTime Created { get; set; }

        [XmlElement("allowedUser")]
        public List<String> AllowedUsers { get; set; }

        [XmlElement("entry")]
        public List<Entry> Entries { get; set; }

        public Playlist()
        {
        }
    }
}