using SubsonicWS.Common;
using SubsonicWS.Common.NestedElements;
using SubsonicWS.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.Browsing
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class GetIndexes : Response<GetIndexes>
    {
        [XmlAttribute("lastModified")]
        public String LastModified { get; set; }

        [XmlElement("shortcut")]
        public List<Shortcut> Shortcuts { get; set; }

        [XmlElement("index")]
        public List<Index> Indexes { get; set; }

        [XmlElement("child")]
        public List<Child> Childs { get; set; }
        
        /// <summary>
        /// Returns an indexed structure of all artists.
        /// </summary>
        /// <param name="musicFolderId">If specified, only return artists in the music folder with the given ID. See getMusicFolders. </param>
        /// <param name="ifModifiedSince">If specified, only return a result if the artist collection has changed since the given time (in milliseconds since 1 Jan 1970).</param>
        /// <returns></returns>
        /// <exception cref="ResponseStatusFailedException">Get indexes failed</exception>
        public async Task Request(int musicFolderId = -1, int ifModifiedSince = -1)
        {
            string otherParam = "";
            if (musicFolderId != -1)
                otherParam += "&musicFolderId=" + musicFolderId;
            if (ifModifiedSince != -1)
                otherParam += "&ifModifiedSince=" + ifModifiedSince;

            GetIndexes i = await Get(otherParam);
            if (i.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Get indexes failed", i.Error);
            this.Copy(i);
            this.LastModified = i.LastModified;
            this.Shortcuts = new List<Shortcut>(i.Shortcuts);
            this.Indexes = new List<Index>(i.Indexes);
            this.Childs = new List<Child>(i.Childs);
        }
    }
}