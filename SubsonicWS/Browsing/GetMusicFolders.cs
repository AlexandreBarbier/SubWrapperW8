using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetMusicFolders : Response<GetMusicFolders>
    {
        [XmlElement("musicFolders")]
        public List<MusicFolder> MusicFolders { get; set; }

        public async Task Request()
        {
            GetMusicFolders m = await Get();
            this.Copy(m);
            this.MusicFolders = new List<MusicFolder>(m.MusicFolders);
        }

    }
}