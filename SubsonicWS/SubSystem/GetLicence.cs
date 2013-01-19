using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
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

        /// <summary>
        ///  Get details about the software license. Takes no extra parameters. 
        ///  Please note that access to the REST API requires that the server has a valid license (after a 30-day trial period). 
        ///  To get a license key you can give a donation to the Subsonic project.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get license failed</exception>
        public async Task Request()
        {
            GetLicence l = await Get();
            if (l.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get license failed", l.Error);
            this.Copy(l);
            this.License = l.License;
        }
    }
}