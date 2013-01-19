using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetArtist : Response<GetArtist>
    {
        [XmlElement("artist")]
        public Artist Artist { get; set; }

        public async Task Request(int id)
        {
            GetArtist a = await Get("&id=" + id);
            this.Copy(a);
            this.Artist = a.Artist;
        }
    }
}