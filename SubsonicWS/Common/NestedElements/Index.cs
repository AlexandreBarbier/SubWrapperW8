using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("index")]
    public class Index
    {
        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlElement("artist")]
        public List<Artist> Artists { get; set; }
    }
}