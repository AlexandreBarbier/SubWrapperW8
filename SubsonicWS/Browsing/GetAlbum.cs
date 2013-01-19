using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetAlbum : Response<GetAlbum>
    {
        [XmlElement("album")]
        public Album Album { get; set; }

        /// <summary>
        /// Returns details for an album, including a list of songs. This method organizes music according to ID3 tags.
        /// </summary>
        /// <param name="id">The album id.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get album failed</exception>
        public async Task Request(int id)
        {
            GetAlbum a = await Get("&id=" + id);
            if (a.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get album failed", a.Error);
            this.Copy(a);
            this.Album = a.Album;
        }
    }
}