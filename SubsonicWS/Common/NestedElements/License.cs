using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("license")]
    public class License
    {
        [XmlAttribute("valid")]
        public Boolean Valid { get; set; }

        [XmlAttribute("email")]
        public String Email { get; set; }

        [XmlAttribute("key")]
        public String Key { get; set; }

        [XmlAttribute("date")]
        public DateTime Date { get; set; }

        public License()
        {
        }
    }
}