using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Sharing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class DeleteShare : Response<DeleteShare>
    {
        /// <summary>
        /// Deletes an existing share.
        /// </summary>
        /// <param name="id">ID of the share to delete.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Delete share failed</exception>
        public async Task Request(int id)
        {
            DeleteShare ds = await Get("&id=" + id);
            if (ds.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Delete share failed", ds.Error);
            this.Copy(ds);
        }
    }
}