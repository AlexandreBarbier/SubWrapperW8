using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetMusicDirectory : Response<GetMusicDirectory>
    {
        [XmlElement("directory")]
        public Directory Directory { get; set; }

        public async Task Request(int id)
        {
            GetMusicDirectory m = await Get("&id="+id);
            this.Copy(m);
            this.Directory = m.Directory;
        }
    }
}