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
    public class GetVideos : Response<GetVideos>
    {
        [XmlArray("videos")]
        [XmlArrayItem("video")]
        public List<Video> Videos { get; set; }

        public async Task Request()
        {
            GetVideos v = await Get();
            this.Copy(v);
            this.Videos = new List<Video>(v.Videos);
        }
    }
}