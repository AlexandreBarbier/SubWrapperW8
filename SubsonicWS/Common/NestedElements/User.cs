using System;
using System.Xml.Serialization;

namespace SubsonicWS.Common.NestedElements
{
    [XmlRoot("user")]
    public class User
    {
        [XmlAttribute("username")]
        public String Username { get; set; }

        [XmlAttribute("email")]
        public String Email { get; set; }

        [XmlAttribute("scrobblingEnabled")]
        public Boolean ScrobblingEnabled { get; set; }

        [XmlAttribute("adminRole")]
        public Boolean AdminRole { get; set; }

        [XmlAttribute("settingsRole")]
        public Boolean SettingsRole { get; set; }

        [XmlAttribute("downloadRole")]
        public Boolean DownloadRole { get; set; }

        [XmlAttribute("uploadRole")]
        public Boolean UploadRole { get; set; }

        [XmlAttribute("playlistRole")]
        public Boolean PlaylistRole { get; set; }

        [XmlAttribute("coverArtRole")]
        public Boolean CoverArtRole { get; set; }

        [XmlAttribute("commentRole")]
        public Boolean CommentRole { get; set; }

        [XmlAttribute("podcastRole")]
        public Boolean PodcastRole { get; set; }

        [XmlAttribute("streamRole")]
        public Boolean StreamRole { get; set; }

        [XmlAttribute("jukeboxRole")]
        public Boolean JukeboxRole { get; set; }

        [XmlAttribute("shareRole")]
        public Boolean ShareRole { get; set; }

        public User()
        {
        }
    }
}