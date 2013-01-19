using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetVideos : Response<GetVideos>
    {
        [XmlArray("videos")]
        [XmlArrayItem("video")]
        public List<Video> Videos { get; set; }

        /// <summary>
        /// Returns all video files.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get song failed</exception>
        public async Task Request()
        {
            GetVideos v = await Get();
            if (v.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get song failed", v.Error);
            this.Copy(v);
            this.Videos = new List<Video>(v.Videos);
        }
    }
}