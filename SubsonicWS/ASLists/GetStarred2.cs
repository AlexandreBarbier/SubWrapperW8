using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.ASLists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetStarred2 : Response<GetStarred2>
    {
        [XmlElement("starred")]
        public Starred Starred { get; set; }

        public async Task Request()
        {
            GetStarred2 np = await Get();
            this.Copy(np);
        }
    }
}