using SubsonicWS.Common;
using SubsonicWS.SubSystem.NestedElements;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.SubSystem
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetLicence : Response<GetLicence>
    {
        [XmlElement("license")]
        public License License { get; set; }

        public GetLicence()
        {
        }

        public async Task Init()
        {
           GetLicence l = await Get();
           this.Copy(l);
           this.License = l.License;
          
        }
    }
}