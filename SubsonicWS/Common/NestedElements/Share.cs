using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("share")]
    public class Share
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("url")]
        public String Url { get; set; }

        [XmlAttribute("description")]
        public String Description { get; set; }

        [XmlAttribute("username")]
        public String Username { get; set; }

        [XmlAttribute("created")]
        public DateTime created { get; set; }

        [XmlAttribute("lastVisited")]
        public DateTime LastVisited { get; set; }

        [XmlAttribute("expires")]
        public DateTime Expires { get; set; }

        [XmlAttribute("visitCount")]
        public int VisitCount { get; set; }

        [XmlElement("entry")]
        public List<Entry> Entries { get; set; }

        public Share()
        {

        }
    }
}