using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;

namespace SubsonicWS.MediaRetrieval
{
    public class MediaRetrieval : Response<MediaRetrieval>
    {
        public static Uri Stream(int id)
        {
            return new Uri(ConnectionInformations.getConnectionString("stream.view", "&id=" + id));
        }

        public static Uri GetCovert(int id, int size = -1)
        {
            String otherParam = "&id=" + id;
            if (size != -1)
                otherParam += "&size=" + size;
            return new Uri(ConnectionInformations.getConnectionString("getCoverArt.view", otherParam));
        }

        public static async Task<Boolean> Download(int id, String name)
        {
            Byte[] t = await getData("download.view", "&id=" + id);
            StorageFile f = await KnownFolders.MusicLibrary.CreateFileAsync(name);
            using (Stream s = await f.OpenStreamForWriteAsync())
            {
                await s.WriteAsync(t, 0, t.Length);
            }
            return false;
        }
    }
}