using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class DeleteUser : Response<DeleteUser>
    {
        public async Task Request(String username)
        {
            DeleteUser item = await Get("&username=" + username);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Delete User failed", item.Error);
            this.Copy(item);
        }
    }
}