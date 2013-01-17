using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("child")]
    public class Child
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("created")]
        public DateTime Created { get; set; }

        [XmlAttribute("Parent")]
        public int Parent { get; set; }

        [XmlAttribute("title")]
        public String Title { get; set; }

        [XmlAttribute("isDir")]
        public Boolean IsDir { get; set; }

        [XmlAttribute("album")]
        public String Album { get; set; }

        [XmlAttribute("artist")]
        public String Artist { get; set; }

        [XmlAttribute("track")]
        public int Track { get; set; }

        [XmlAttribute("year")]
        public int Year { get; set; }

        [XmlAttribute("genre")]
        public String Genre { get; set; }

        [XmlAttribute("coverArt")]
        public int CoverArt { get; set; }

        [XmlAttribute("size")]
        public int Size { get; set; }

        [XmlAttribute("contentType")]
        public String ContentType { get; set; }

        [XmlAttribute("suffix")]
        public String Suffix { get; set; }

        [XmlAttribute("transcodedContentType")]
        public String TranscodedContentType { get; set; }

        [XmlAttribute("transcodedSuffix")]
        public String TranscodedSuffix { get; set; }

        [XmlAttribute("duration")]
        public int Duration { get; set; }

        [XmlAttribute("bitRate")]
        public int BitRate { get; set; }

        [XmlAttribute("path")]
        public String Path { get; set; }

        public Child()
        {
        }
    }
}