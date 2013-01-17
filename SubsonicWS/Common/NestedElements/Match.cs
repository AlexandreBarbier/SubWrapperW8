using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("match")]
    public class Match
    {
        [XmlAttribute("username")]
        public String Username { get; set; }

        [XmlAttribute("minutesAgo")]
        public int MinutesAgo { get; set; }

        [XmlAttribute("playerId")]
        public int PlayerId { get; set; }

        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("parent")]
        public int Parent { get; set; }

        [XmlAttribute("title")]
        public String Title { get; set; }

        [XmlAttribute("track")]
        public int Track { get; set; }

        [XmlAttribute("year")]
        public int Year { get; set; }

        [XmlAttribute("genre")]
        public String Genre { get; set; }

        [XmlAttribute("album")]
        public String Album { get; set; }

        [XmlAttribute("artist")]
        public String Artist { get; set; }

        [XmlAttribute("isDir")]
        public Boolean IsDir { get; set; }

        [XmlAttribute("coverArt")]
        public int CoverArt { get; set; }

        [XmlAttribute("Size")]
        public int Size { get; set; }

        [XmlAttribute("suffix")]
        public String Suffix { get; set; }

        [XmlAttribute("contentType")]
        public String ContentType { get; set; }

        [XmlAttribute("transcodedContentType")]
        public String TranscodedContentType { get; set; }

        [XmlAttribute("transcodedSuffix")]
        public String TranscodedSuffix { get; set; }

        [XmlAttribute("path")]
        public String Path { get; set; }

        public Match()
        {
        }
    }
}