﻿using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetUser : Response<GetUser>
    {
        [XmlElement("user")]
        public User User { get; set; }

        public async Task Request(String username)
        {
            GetUser item = await Get("&username=" + username);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get User failed", item.Error);
            this.Copy(item);
            this.User = item.User;
        }
    }
}