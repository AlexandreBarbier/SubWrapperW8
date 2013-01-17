using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SubsonicWS;
using SubsonicWSTestUnit.Common;

namespace SubsonicWSTestUnit
{
    [TestClass]
    public class SubsonicWSTestBrowsing
    {
        [TestMethod]
        public void TestGetMusicDirectory()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetMusicDirectory p = new SubsonicWS.Browsing.GetMusicDirectory();
            var t = p.Init(0);
            while (!t.IsCompleted)
                t.Wait(10);
            Assert.IsNotNull(p.Directory);
        }

        [TestMethod]
        public void TestGetAlbum()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetAlbum p = new SubsonicWS.Browsing.GetAlbum();
            var t = p.Init(141);
            while (!t.IsCompleted)
                t.Wait(10);
            //Assert.IsNotNull(p.Album);
            Assert.IsTrue(p.Album.Songs.Count>0);
        }

        [TestMethod]
        public void TestGetArtist()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetArtist p = new SubsonicWS.Browsing.GetArtist();
            var t = p.Init(41);
            while (!t.IsCompleted)
                t.Wait(10);
            Assert.IsNotNull(p.Artist);
        }

        [TestMethod]
        public void TestGetArtists()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetArtists p = new SubsonicWS.Browsing.GetArtists();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);
            Assert.IsNotNull(p.Artists);
        }

        [TestMethod]
        public void TestGetIndexes()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetIndexes p = new SubsonicWS.Browsing.GetIndexes();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);
            Assert.IsTrue(p.Indexes != null || p.Shortcuts != null || p.Childs != null);
        }

        [TestMethod]
        public void TestGetMusicFolder()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetMusicFolders p = new SubsonicWS.Browsing.GetMusicFolders();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);
            //Assert.IsNotNull(p.MusicFolders);
            Assert.IsTrue(p.MusicFolders.Count > 0);
        }

        [TestMethod]
        public void TestGetSong()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetSong p = new SubsonicWS.Browsing.GetSong();
            var t = p.Init(2082);
            while (!t.IsCompleted)
                t.Wait(10);            
            Assert.IsNotNull(p.Song);
        }

        [TestMethod]
        public void TestGetVideos()
        {
            ConnectionInformations.initConnection(Constants.Login, Constants.Password, Constants.Server, Constants.Port, Constants.Version, Constants.UniqId);
            SubsonicWS.Browsing.GetVideos p = new SubsonicWS.Browsing.GetVideos();
            var t = p.Init();
            while (!t.IsCompleted)
                t.Wait(10);       
            Assert.IsNotNull(p.Videos);
        }
    }
}