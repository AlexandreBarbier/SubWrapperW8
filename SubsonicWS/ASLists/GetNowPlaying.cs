using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.ASLists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetNowPlaying : Response<GetNowPlaying>
    {
        [XmlArray("albumList")]
        [XmlArrayItem("album")]
        public List<Entry> NowPlaying { get; set; }

        public async Task Request()
        {
            GetNowPlaying np = await Get();
            this.Copy(np);
            this.NowPlaying = new List<Entry>(np.NowPlaying);

        }
    }
}
