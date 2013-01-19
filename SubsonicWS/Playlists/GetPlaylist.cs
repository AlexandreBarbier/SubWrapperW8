using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Playlists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetPlaylist : Response<GetPlaylist>
    {
        [XmlElement]
        public Playlist Playlist { get; set; }

        public async Task Request(int id)
        {
            GetPlaylist p = await Get("&id=" + id);
            this.Copy(p);
            this.Playlist = p.Playlist;
        }
    }
}