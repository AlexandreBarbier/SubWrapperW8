using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class ChangePassword : Response<ChangePassword>
    {
        public async Task Request(String username, String password)
        {
            ChangePassword item = await Get("&username=" + username + "&password=" + password);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Change Password failed", item.Error);
            this.Copy(item);
        }
    }
}