using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetSong : Response<GetSong>
    {
        [XmlElement("song")]
        public Song Song { get; set; }


        public async Task Init(int p)
        {
            GetSong s = await Get("&id=" + p);
            this.Copy(s);
            this.Song = s.Song;
        }
    }
}