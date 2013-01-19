using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetMusicDirectory : Response<GetMusicDirectory>
    {
        [XmlElement("directory")]
        public Directory Directory { get; set; }
        
        /// <summary>
        /// Returns a listing of all files in a music directory. Typically used to get list of albums for an artist, or list of songs for an album.
        /// </summary>
        /// <param name="id">A string which uniquely identifies the music folder. Obtained by calls to getIndexes or getMusicDirectory.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get music directory failed</exception>
        public async Task Request(int id)
        {
            GetMusicDirectory m = await Get("&id=" + id);
            if (m.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get music directory failed", m.Error);
            this.Copy(m);
            this.Directory = m.Directory;
        }
    }
}