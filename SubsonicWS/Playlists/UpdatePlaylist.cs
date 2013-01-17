using SubsonicWS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Playlists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class UpdatePlaylist : Response<UpdatePlaylist>
    {
        /// <summary>
        /// Updates the specified playlist.
        /// </summary>
        /// <param name="playlistId">The playlist id.</param>
        /// <param name="name">The human-readable name of the playlist.</param>
        /// <param name="comment">The playlist comment.</param>
        /// <param name="songIdToAdd">The song id to add.</param>
        /// <param name="songIndexToRemove">The song index to remove.</param>
        /// <returns>true on success</returns>
        public async Task<Boolean> Update(int playlistId, String name = "", String comment = "", int[] songIdToAdd = null, int[] songIndexToRemove = null)
        {
            String otherParams = "";
            otherParams += "&playlistId=" + playlistId;
            if (!String.IsNullOrWhiteSpace(name))
                otherParams += "&name=" + name;
            if (!String.IsNullOrWhiteSpace(comment))
                otherParams += "&comment=" + comment;
            if (songIdToAdd != null)
                foreach (int item in songIdToAdd)
                    otherParams += "&songIdToAdd=" + item;
            if (songIndexToRemove != null)
                foreach (int item in songIndexToRemove)
                    otherParams += "&songIdToAdd=" + item;

            UpdatePlaylist p = await Get(otherParams);
            this.Copy(p);
            return StatusValue == Common.ResponseStatus.Ok;
        }
    }
}
