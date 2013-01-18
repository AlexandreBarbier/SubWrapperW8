using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Sharing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetShares : Response<GetShares>
    {
        [XmlArray("shares")]
        [XmlArrayItem("share")]
        public List<Share> Shares { get; set; }

        /// <summary>
        /// Requests this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">share get request failed</exception>
        public async Task Request()
        {
            GetShares s = await Get();
            if (s.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("share get request failed", s.Error);

            this.Copy(s);
            this.Shares = new List<Share>(s.Shares);
        }
    }
}