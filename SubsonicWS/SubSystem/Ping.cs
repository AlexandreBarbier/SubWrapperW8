using SubsonicWS.Common;
using System;
using System.IO;
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

        public async Task Init()
        {
           Ping p = await Get();
           this.Copy(p);
        }
    }
}