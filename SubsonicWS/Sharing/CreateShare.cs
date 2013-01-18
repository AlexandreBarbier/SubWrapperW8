using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Sharing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class CreateShare : Response<CreateShare>
    {
        /*  id 	            Yes 		ID of a song, album or video to share. Use one id parameter for each entry to share.
            description 	No 		A user-defined description that will be displayed to people visiting the shared media.
            expires 	    No 		The time at which the share expires. Given as milliseconds since 1970.
         */
        [XmlArray("shares")]
        [XmlArrayItem("share")]
        public List<Share> Shares { get; set; }
  
        public async Task Create(List<int> ids, String description = "", int expires = -1)
        {
            String otherParam = "";
            foreach (var item in ids)
                otherParam = "&id=" + item;

            if (!String.IsNullOrWhiteSpace(description))
                otherParam += "&description=" + description;
            if (expires != -1)
                otherParam += "&expires=" + expires;
            CreateShare cs = await Get(otherParam);
            if (cs.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("create share fail", cs.Error);
            this.Copy(cs);
            this.Shares = new List<Share>(cs.Shares);
        }
    }
}
