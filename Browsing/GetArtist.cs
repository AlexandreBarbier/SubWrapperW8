using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetArtist : Response<GetArtist>
    {
        [XmlElement("artist")]
        public Artist Artist { get; set; }

        public async Task Init(int id)
        {
            GetArtist a = await Get("&id=" + id);
            this.Copy(a);
            this.Artist = a.Artist;
        }
    }
}