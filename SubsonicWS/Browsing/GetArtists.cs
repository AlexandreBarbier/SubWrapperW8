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
    public class GetArtists : Response<GetArtists>
    {
        [XmlArray("artists")]
        [XmlArrayItem("index")]
        public List<Index> Artists { get; set; }

        public async Task Request()
        {
            GetArtists a = await Get();
            this.Copy(a);
            this.Artists = new List<Index>(a.Artists);

        }
    }
}