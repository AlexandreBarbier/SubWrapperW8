using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("shortcut")]
    public class Shortcut
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        public Shortcut()
        {
        }
    }
}