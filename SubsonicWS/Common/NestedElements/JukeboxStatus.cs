using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("jukeboxStatus")]
    public class JukeboxStatus
    {
        [XmlAttribute("currentIndex")]
        public int CurrentIndex { get; set; }

        [XmlAttribute("playing")]
        public Boolean Playing { get; set; }

        [XmlAttribute("gain")]
        public Double Gain { get; set; }

        [XmlAttribute("position")]
        public int Position { get; set; }

        public JukeboxStatus()
        {
        }
    }
}