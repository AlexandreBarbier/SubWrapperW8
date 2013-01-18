using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("channel")]
    public class Channel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("url")]
        public String Url { get; set; }

        [XmlAttribute("title")]
        public String Title { get; set; }

        [XmlAttribute("decription")]
        public String Description { get; set; }

        [XmlAttribute("status")]
        public String Status { get; set; }

        [XmlAttribute("errorMessage")]
        public String ErrorMessage { get; set; }

        [XmlElement("episode")]
        public List<Episode> Episodes { get; set; }
        
        public Channel()
        {
        }
    }
}