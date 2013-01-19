using SubsonicWS.Common;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.SubSystem
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Ping : Response<Ping>
    {
        public Ping()
        {
        }

        public async Task Request()
        {
            Ping p = await Get();
            this.Copy(p);
        }
    }
}