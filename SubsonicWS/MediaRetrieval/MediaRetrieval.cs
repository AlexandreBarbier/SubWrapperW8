using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace SubsonicWS.MediaRetrieval
{
    public class MediaRetrieval : Response<MediaRetrieval>
    {
        /// <summary>
        /// Streams the specified file.
        /// </summary>
        /// <param name="id">The id of the file.</param>
        /// <returns>the Uri representing the file address.(easiest way to retrieve media with media element)</returns>
        public static Uri Stream(int id)
        {
            return new Uri(ConnectionInformations.getConnectionString("stream.view", "&id=" + id));
        }

        /// <summary>
        /// Gets the covert.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="size">The size.</param>
        /// <returns>the Uri representing the image address.(easiest way to retrieve image with ImageSource)</returns>
        public static Uri GetCovert(int id, int size = -1)
        {
            String otherParam = "&id=" + id;
            if (size != -1)
                otherParam += "&size=" + size;
            return new Uri(ConnectionInformations.getConnectionString("getCoverArt.view", otherParam));
        }

        /// <summary>
        /// Downloads the specified file.
        /// </summary>
        /// <param name="id">The id of the file.</param>
        /// <param name="name">The name of the downloaded file.</param>
        /// <returns>true on success</returns>
        public static async Task<Boolean> Download(int id, String name)
        {
            try
            {
                Byte[] t = await getData("download.view", "&id=" + id);
                StorageFile f = await KnownFolders.MusicLibrary.CreateFileAsync(name);
                using (Stream s = await f.OpenStreamForWriteAsync())
                {
                    await s.WriteAsync(t, 0, t.Length);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the avatar.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <returns>the Uri representing the image address.(easiest way to retrieve image with ImageSource)</returns>
        public static Uri GetAvatar(String username)
        {
            return new Uri(ConnectionInformations.getConnectionString("getAvatar.view", "&username=" + username));
        }
    }
}