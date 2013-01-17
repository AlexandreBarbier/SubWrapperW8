using SubsonicWS.ASLists;
using SubsonicWS.Browsing;
using SubsonicWS.SubSystem;
using System;
using System.Collections.Generic;

namespace SubsonicWS.Common
{
    public class Constants
    {
        public const String SubNamespace = "http://subsonic.org/restapi";
        public const String SubResponse = "subsonic-response";

        public static readonly Dictionary<AlbumListTypeEnum, String> AlbumListType = new Dictionary<AlbumListTypeEnum, String>
        {
            {AlbumListTypeEnum.alphabeticalByArtist, "alphabeticalByArtist"},
            {AlbumListTypeEnum.alphabeticalByName, "alphabeticalByName"},
            {AlbumListTypeEnum.frequent, "frequent"},
            {AlbumListTypeEnum.highest, "highest"},
            {AlbumListTypeEnum.newest, "newest"},
            {AlbumListTypeEnum.random, "random"},
            {AlbumListTypeEnum.recent, "recent"},
            {AlbumListTypeEnum.starred, "starred"}
        };

        public static readonly Dictionary<Type, String> Pages = new Dictionary<Type, String>
        {
        {typeof(Ping), "ping.view"},
        {typeof(GetLicence), "getLicense.view"},
        {typeof(GetMusicFolders),"getMusicFolders.view"},
        {typeof(GetIndexes),"getIndexes.view"},
        {typeof(GetMusicDirectory),"getMusicDirectory.view"},
        {typeof(GetArtists),"getArtists.view"},
        {typeof(GetArtist),"getArtist.view"},
        {typeof(GetAlbum),"getAlbum.view"},
        {typeof(GetSong),"getSong.view"},
        {typeof(GetVideos),"getVideos.view"},
        {typeof(GetAlbumList),"getAlbumList.view"},
        {typeof(GetAlbumList2),"getAlbumList2.view"},
        {typeof(GetRandomSongs),"getRandomSongs.view"}
        //{PagesEnumeration.getNowPlaying,"getNowPlaying.view"},
        //{PagesEnumeration.getStarred,"getStarred.view"},
        //{PagesEnumeration.getStarred2,"getStarred2.view"},
        //{PagesEnumeration.search,"search.view"},
        //{PagesEnumeration.search2,"search2.view"},
        //{PagesEnumeration.search3,"search3.view"},
        //{PagesEnumeration.getPlaylists,"getPlaylists.view"},
        //{PagesEnumeration.getPlaylist,"getPlaylist.view"},
        //{PagesEnumeration.createPlaylist,"createPlaylist.view"},
        //{PagesEnumeration.updatePlaylist,"updatePlaylist.view"},
        //{PagesEnumeration.deletePlaylist,"deletePlaylist.view"},
        //{PagesEnumeration.stream,"stream.view"},
        //{PagesEnumeration.download,"download.view"},
        //{PagesEnumeration.hls,"hls.view"},
        //{PagesEnumeration.getCoverArt,"getCoverArt.view"},
        //{PagesEnumeration.getLyrics,"getLyrics.view"},
        //{PagesEnumeration.getAvatar,"getAvatar.view"},
        //{PagesEnumeration.star,"star.view"},
        //{PagesEnumeration.unstar,"unstar.view"},
        //{PagesEnumeration.setRating,"setRating.view"},
        //{PagesEnumeration.scrobble,"scrobble.view"},
        //{PagesEnumeration.getShares,"getShares.view"},
        //{PagesEnumeration.createShare,"createShare.view"},
        //{PagesEnumeration.updateShare,"updateShare.view"},
        //{PagesEnumeration.deleteShare,"deleteShare.view"},
        //{PagesEnumeration.getPodcasts,"getPodcasts.view"},
        //{PagesEnumeration.jukeboxControl,"jukeboxControl.view"},
        //{PagesEnumeration.getChatMessages,"getChatMessages.view"},
        //{PagesEnumeration.addChatMessage,"addChatMessage.view"},
        //{PagesEnumeration.getUser,"getUser.view"},
        //{PagesEnumeration.getUsers,"getUsers.view"},
        //{PagesEnumeration.createUser,"createUser.view"},
        //{PagesEnumeration.deleteUser,"deleteUser.view"},
        //{PagesEnumeration.changePassword,"changePassword.view"}
        };
    }
}