using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.ASLists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetStarred : Response<GetStarred>
    {
        [XmlElement("starred")]
        public Starred Starred { get; set; }

        public async Task Request()
        {
            GetStarred np = await Get();
            this.Copy(np);
        }
    }
}