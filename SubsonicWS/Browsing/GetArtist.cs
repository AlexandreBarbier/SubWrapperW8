using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetArtist : Response<GetArtist>
    {
        [XmlElement("artist")]
        public Artist Artist { get; set; }

        /// <summary>
        /// Returns details for an artist, including a list of albums. This method organizes music according to ID3 tags
        /// </summary>
        /// <param name="id">The Artist id.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get artist failed</exception>
        public async Task Request(int id)
        {
            GetArtist a = await Get("&id=" + id);
            if (a.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get artist failed", a.Error);
            this.Copy(a);
            this.Artist = a.Artist;
        }
    }
}