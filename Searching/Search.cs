using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Searching
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Search : Response<Search>
    {
        [XmlElement("searchResult")]
        public SearchResult SearchResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="artist">Artist to search for</param>
        /// <param name="album">Album to searh for.</param>
        /// <param name="title">Song title to search for.</param>
        /// <param name="any">Searches all fields.</param>
        /// <param name="count">Maximum number of results to return.</param>
        /// <param name="offset">Search result offset. Used for paging.</param>
        /// <param name="newerThan">Only return matches that are newer than this. Given as milliseconds since 1970.</param>
        /// <returns></returns>
        public async Task Init(String artist = "", String album = "", String title = "", Boolean? any = null, int count = 20, int offset = 0, int newerThan = -1)
        {
            String otherParam = "";
            otherParam += "&count=" + count;
            otherParam += "&offset=" + offset;
            if (!String.IsNullOrWhiteSpace(artist))
                otherParam += "&artist="+artist;
            if (!String.IsNullOrWhiteSpace(album))
                otherParam += "&album=" + album;
            if (!String.IsNullOrWhiteSpace(title))
                otherParam += "&title=" + title;
            if (any != null)
                otherParam += "&any=" + any;
            if (newerThan != -1)
                otherParam += "&newerThan=" + newerThan;
            Search s = await Get(otherParam);
            this.Copy(s);
            this.SearchResult = s.SearchResult;
        }
    }
}
