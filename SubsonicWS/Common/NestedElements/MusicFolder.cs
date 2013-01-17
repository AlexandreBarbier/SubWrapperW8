using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("musicFolder")]
    public class MusicFolder
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public String Name { get; set; }

        public MusicFolder()
        {
        }
    }
}