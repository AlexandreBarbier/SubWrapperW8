using System;
using System.Threading.Tasks;

namespace SubsonicWS.Playlists
{
    public class CreatePlaylist : Response<CreatePlaylist>
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="playlistId">(if updating) 	The playlist ID.</param>
        /// <param name="name">(if creating) The human-readable name of the playlist.</param>
        /// <param name="songIds">ID of a song in the playlist. Use one songId parameter for each song in the playlist.</param>
        /// <returns>true on success</returns>
        public async Task<Boolean> New(int playlistId = -1, String name = "", params int[] songIds)
        {
            String otherParams = "";
            if (playlistId != -1)
                otherParams += "&playlistId=" + playlistId;
            if (!String.IsNullOrWhiteSpace(name))
                otherParams += "&name=" + name;
            foreach (int item in songIds)
                otherParams += "&songId=" + item;

            CreatePlaylist p = await Get(otherParams);
            this.Copy(p);
            return StatusValue == Common.ResponseStatus.Ok;
        }
    }
}