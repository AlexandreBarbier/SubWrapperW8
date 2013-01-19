using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetUsers : Response<GetUsers>
    {
        [XmlArray("users")]
        [XmlArrayItem("user")]
        public List<User> Users { get; set; }

        public async Task Request()
        {
            GetUsers item = await Get();
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get Users failed", item.Error);
            this.Copy(item);
            this.Users = new List<User>(item.Users);
        }
    }
}