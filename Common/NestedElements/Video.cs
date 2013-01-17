using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("video")]
    public class Video
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("parent")]
        public int Parent { get; set; }

        [XmlAttribute("title")]
        public String Title { get; set; }

        [XmlAttribute("album")]
        public String Album { get; set; }

        [XmlAttribute("isDir")]
        public Boolean IsDir { get; set; }

        [XmlAttribute("coverArt")]
        public int CoverArt { get; set; }

        [XmlAttribute("created")]
        public DateTime Created { get; set; }

        [XmlAttribute("duration")]
        public int Duration { get; set; }

        [XmlAttribute("bitRate")]
        public int BitRate { get; set; }

        [XmlAttribute("Size")]
        public int Size { get; set; }

        [XmlAttribute("suffix")]
        public String Suffix { get; set; }

        [XmlAttribute("contentType")]
        public String ContentType { get; set; }

        [XmlAttribute("isVideo")]
        public Boolean IsVideo { get; set; }

        [XmlAttribute("path")]
        public String Path { get; set; }

        [XmlAttribute("transcodedSuffix")]
        public String TranscodedSuffix { get; set; }

        [XmlAttribute("transcodedContentType")]
        public String TranscodedContentType { get; set; }

        public Video()
        {
        }
    }
}