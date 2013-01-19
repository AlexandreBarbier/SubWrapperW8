using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Chat
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetChatMessages : Response<GetChatMessages>
    {
        [XmlArray("chatMessages")]
        [XmlArrayItem("chatMessage")]
        public List<ChatMessage> ChatMessages { get; set; }

        public async Task Request(int since = -1)
        {
            String otherParam = "";
            if (since != -1)
                otherParam += "&since=" + since;
            GetChatMessages cm = await Get(otherParam);
            if (cm.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get chat message failed", cm.Error);
            this.Copy(cm);
        }
    }
}