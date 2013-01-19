using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetArtists : Response<GetArtists>
    {
        [XmlArray("artists")]
        [XmlArrayItem("index")]
        public List<Index> Artists { get; set; }

        //
        /// <summary>
        /// Similar to getIndexes, but organizes music according to ID3 tags.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get artists failed</exception>
        public async Task Request()
        {
            GetArtists a = await Get();
            if (a.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get artists failed", a.Error);
            this.Copy(a);
            this.Artists = new List<Index>(a.Artists);
        }
    }
}