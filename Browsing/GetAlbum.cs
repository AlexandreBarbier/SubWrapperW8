using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetAlbum : Response<GetAlbum>
    {
        [XmlElement("album")]
        public Album Album { get; set; }

        public async Task Init(int id)
        {
            GetAlbum a = await Get("&id=" + id);
            this.Copy(a);
            this.Album = a.Album;
        }
    }
}