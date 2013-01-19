using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    class ChangePassword : Response<ChangePassword>
    {
        public async Task Request(String username,String password)
        {
            ChangePassword item = await Get("&username=" + username + "&password=" + password);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Change Password failed", item.Error);
            this.Copy(item);
        }
    }
}
