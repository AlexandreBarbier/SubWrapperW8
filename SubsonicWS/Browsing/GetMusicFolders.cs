using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetMusicFolders : Response<GetMusicFolders>
    {
        [XmlElement("musicFolders")]
        public List<MusicFolder> MusicFolders { get; set; }

        /// <summary>
        /// Returns all configured top-level music folders. Takes no extra parameters.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get music folders failed</exception>
        public async Task Request()
        {
            GetMusicFolders m = await Get();
            if (m.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get music folders failed", m.Error);
            this.Copy(m);
            this.MusicFolders = new List<MusicFolder>(m.MusicFolders);
        }
    }
}