using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Podcast
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetPodcasts : Response<GetPodcasts>
    {
        [XmlArray("podcasts")]
        [XmlArrayItem("channel")]
        public List<Channel> Channels { get; set; }

        /// <summary>
        /// Requests this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get podcast failed</exception>
        public async Task Request()
        {
            GetPodcasts p = await Get();
            if (p.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get podcast failed", p.Error);
            this.Copy(p);
            this.Channels = new List<Channel>(p.Channels);
        }
    }
}