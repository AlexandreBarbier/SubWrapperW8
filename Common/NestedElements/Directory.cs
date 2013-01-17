using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("directory")]
    public class Directory
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        [XmlAttribute("parent")]
        public int Parent { get; set; }

        [XmlElement("child")]
        public List<Child> Childs { get; set; }
    }
}