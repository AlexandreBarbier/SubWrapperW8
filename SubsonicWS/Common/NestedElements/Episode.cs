using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("episode")]
    public class Episode
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("streamId")]
        public int StreamId { get; set; }

        [XmlAttribute("title")]
        public String Title { get; set; }

        [XmlAttribute("description")]
        public String Description { get; set; }

        [XmlAttribute("publishDate")]
        public DateTime PublishDate { get; set; }

        [XmlAttribute("status")]
        public String Status { get; set; }

        [XmlAttribute("parent")]
        public int Parent { get; set; }

        [XmlAttribute("isDir")]
        public Boolean isDir { get; set; }

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

        [XmlAttribute("duration")]
        public int Duration { get; set; }

        [XmlAttribute("bitRate")]
        public int BitRate { get; set; }

        [XmlAttribute("path")]
        public String Path { get; set; }

        public Episode()
        {
        }
    }
}