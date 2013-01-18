using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Jukebox
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class JukeboxControl : Response<JukeboxControl>
    {
        [XmlElement("jukeboxStatus")]
        public JukeboxStatus JukeboxStatus { get; set; }
        [XmlElement("jukeboxPlaylist")]
        public JukeboxPlaylist Playlist { get; set; }

        /// <summary>
        /// Controls the jukebox, i.e., playback directly on the server's audio hardware. Note: The user must be authorized to control the jukebox (see Settings > Users > User is allowed to play files in jukebox mode).
        /// </summary>
        /// <param name="action">The operation to perform. Must be one of: get, status (since 1.7.0), set (since 1.7.0), start, stop, skip, add, clear, remove, shuffle, setGain</param>
        /// <param name="index">Used by skip and remove. Zero-based index of the song to skip to or remove.</param>
        /// <param name="offset">(Since 1.7.0) Used by skip. Start playing this many seconds into the track.</param>
        /// <param name="id">Used by add and set. ID of song to add to the jukebox playlist. Use multiple id parameters to add many songs in the same request. (set is similar to a clear followed by a add, but will not change the currently playing track.)</param>
        /// <param name="gain">Used by setGain to control the playback volume. A float value between 0.0 and 1.0.</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Action on jukebox failed</exception>
        public async Task Request(JukeBoxAction action, int index = -1, int offset = -1, int id = -1, double gain = -1)
        {
            String otherParameter = "&action=" + Constants.JuckeBoxActions[action];
            if (index != -1)
                otherParameter += "&index=" + index;
            if (offset != -1)
                otherParameter += "&offset=" + offset;
            if (id != -1)
                otherParameter += "&id=" + id;
            if (gain != -1)
                otherParameter += "&gain=" + gain;
            JukeboxControl jc = await Get(otherParameter);
            if (jc.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Action on jukebox failed", jc.Error);
            this.Copy(jc);
            this.JukeboxStatus = jc.JukeboxStatus;
            this.Playlist = jc.Playlist;
        }
    }
}
