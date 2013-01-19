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
    class DeleteUser : Response<DeleteUser>
    {
        public async Task Request(String username)
        {
            DeleteUser item = await Get("&username="+username);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Delete User failed", item.Error);
            this.Copy(item);
        }
    }
}
