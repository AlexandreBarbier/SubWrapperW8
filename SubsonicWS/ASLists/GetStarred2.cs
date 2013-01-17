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
    public class GetStarred2 : Response<GetStarred2>
    {
        [XmlElement("starred")]
        public Starred Starred { get; set; }

        public async Task Init()
        {
            GetStarred2 np = await Get();
            this.Copy(np);
        }
    }
}
