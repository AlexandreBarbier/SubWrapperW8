using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("album")]
    public class Album
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("covertArt")]
        public String CoverArt { get; set; }

        [XmlAttribute("songCount")]
        public int SongCount { get; set; }

        [XmlAttribute("created")]
        public DateTime Created { get; set; }

        [XmlAttribute("duration")]
        public int Duration { get; set; }

        [XmlAttribute("artist")]
        public String Artist { get; set; }

        [XmlAttribute("artistId")]
        public int ArtistId { get; set; }

        [XmlAttribute("userRating")]
        public int UserRating { get; set; }

        [XmlAttribute("averageRating")]
        public double AverageRating { get; set; }

        [XmlElement("song")]
        public List<Song> Songs { get; set; }

        public Album()
        {
        }
    }
}