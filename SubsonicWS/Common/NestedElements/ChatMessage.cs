using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("chatMessage")]
    public class ChatMessage
    {
        [XmlAttribute("username")]
        public String Username { get; set; }

        [XmlAttribute("time")]
        public int Time { get; set; }

        [XmlAttribute("message")]
        public String Message { get; set; }

        public ChatMessage()
        {
        }
    }
}