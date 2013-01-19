using SubsonicWS.Common;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Playlists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class DeletePlaylist : Response<DeletePlaylist>
    {
        /// <summary>
        /// Deletes the specified playlist.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public async Task<Boolean> Delete(int id)
        {
            DeletePlaylist d = await Get("&id=" + id);
            this.Copy(d);
            return this.StatusValue == ResponseStatus.Ok;
        }
    }
}