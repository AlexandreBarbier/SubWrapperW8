using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Playlists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetPlaylists : Response<GetPlaylists>
    {
        [XmlArray("playlists")]
        [XmlArrayItem("playlist")]
        public List<Playlist> Playlists { get; set; }

        public async Task Init(String username = "")
        {
            String otherParam = "";
            if (!String.IsNullOrWhiteSpace(username))
                otherParam += "&username=" + username;
            GetPlaylists p = await Get(otherParam);
            this.Copy(p);
            this.Playlists = new List<Playlist>(p.Playlists);
        }
    }
}
