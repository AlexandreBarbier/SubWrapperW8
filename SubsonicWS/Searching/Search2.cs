using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Searching
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class Search2 : Response<Search2>
    {
        [XmlElement("searchResult2")]
        public List<SearchResult2> SearchResult { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="query">Search query.</param>
        /// <param name="artistCount">Maximum number of artists to return.</param>
        /// <param name="artistOffset">Search result offset for artists. Used for paging.</param>
        /// <param name="albumCount">Maximum number of albums to return.</param>
        /// <param name="albumOffset">Search result offset for albums. Used for paging.</param>
        /// <param name="songCount">Maximum number of songs to return.</param>
        /// <param name="songOffset">Search result offset for songs. Used for paging.</param>
        /// <returns></returns>
        public async Task Request(String query, int artistCount = 20, int artistOffset = 0, int albumCount = 20, int albumOffset = 0, int songCount = 20, int songOffset = 0)
        {
            String otherParam = "";
            otherParam += "&query=" + query;
            otherParam += "&artistCount=" + artistCount;
            otherParam += "&artistOffset=" + artistOffset;
            otherParam += "&albumCount=" + albumCount;
            otherParam += "&albumOffset=" + albumOffset;
            otherParam += "&songCount=" + songCount;
            otherParam += "&songOffset=" + songOffset;
            Search2 s = await Get(otherParam);
            this.Copy(s);
            this.SearchResult = s.SearchResult;
        }
    }
}