using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Sharing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class UpdateShare : Response<UpdateShare>
    {
        /// <summary>
        /// Updates the description and/or expiration date for an existing share.
        /// </summary>
        /// <param name="id">ID of the share to update.</param>
        /// <param name="description">A user-defined description that will be displayed to people visiting the shared media.</param>
        /// <param name="expires">The time at which the share expires. Given as milliseconds since 1970, or zero to remove the expiration.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Update Share failed + us.Error</exception>
        public async Task Request(int id, string description = "", int expires = -1)
        {
            String otherParam = "&id=" + id;
            if (String.IsNullOrWhiteSpace(description))
                otherParam += "&description=" + description;
            UpdateShare us = await Get(otherParam);
            if (us.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Update Share failed" + us.Error);
            this.Copy(us);
        }
    }
}