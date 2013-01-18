using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("jukeboxPlaylist")]
    public class JukeboxPlaylist
    {
        [XmlAttribute("currentIndex")]
        public int CurrentIndex { get; set; }
        [XmlAttribute("playing")]
        public Boolean Playing { get; set; }
        [XmlAttribute("gain")]
        public Double Gain { get; set; }
        [XmlAttribute("position")]
        public int Position { get; set; }
        [XmlElement("entry")]
        public List<Entry> Entries { get; set; }
        
        public JukeboxPlaylist()
        {

        }
    }
}
