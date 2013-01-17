using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common
{
    [XmlRoot("error")]
    public class ResponseError
    {
        [XmlAttribute("code")]
        public int Code { get; set; }

        [XmlAttribute("message")]
        public String Message { get; set; }

        public ResponseError()
        {
        }
    }
}