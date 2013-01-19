using SubsonicWS.Common;
using SubsonicWS.Exceptions;
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

        /// <summary>
        /// Used to test connectivity with the server. Takes no extra parameters.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Ping failed</exception>
        public async Task Request()
        {
            Ping p = await Get();
            if (p.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Ping failed", p.Error);
            this.Copy(p);
        }
    }
}