using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Chat
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class AddChatMessage : Response<AddChatMessage>
    {
        public async Task Request(String message)
        {
            AddChatMessage cm = await Get("&message=" + message);
            if (cm.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Add chat message failed", cm.Error);
            this.Copy(cm);
        }
    }
}