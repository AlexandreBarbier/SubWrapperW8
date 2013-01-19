using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetSong : Response<GetSong>
    {
        [XmlElement("song")]
        public Song Song { get; set; }

        /// <summary>
        /// Returns details for a song.
        /// </summary>
        /// <param name="id">The song ID.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get song failed</exception>
        public async Task Request(int id)
        {
            GetSong s = await Get("&id=" + id);
            if (s.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get song failed", s.Error);
            this.Copy(s);
            this.Song = s.Song;
        }
    }
}