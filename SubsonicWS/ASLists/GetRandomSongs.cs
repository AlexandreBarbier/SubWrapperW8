using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.ASLists
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetRandomSongs : Response<GetRandomSongs>
    {
        [XmlArray("randomSongs")]
        [XmlArrayItem("song")]
        public List<Song> Songs { get; set; }

        public async Task Init(int size = 10, String genre = "", int year = 0, int fromYear = 0, int toYear = 0, int musicFolderId = 0)
        {
            String otherParam = "&size=" + size;
            if (!String.IsNullOrWhiteSpace(genre))
                otherParam += "&genre=" + genre;
            if (year != 0)
                otherParam += "&year=" + year;
            if (fromYear != 0)
                otherParam += "&fromYear=" + fromYear;
            if (toYear != 0)
                otherParam += "&toYear=" + toYear;
            if (musicFolderId != 0)
                otherParam += "&musicFolderId" + musicFolderId;
            GetRandomSongs rs = await Get(otherParam);
            this.Copy(rs);
            this.Songs = new List<Song>(rs.Songs);
        }
    }
}