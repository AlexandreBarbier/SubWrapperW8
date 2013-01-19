using SubsonicWS.ASLists;
using SubsonicWS.Browsing;
using SubsonicWS.Chat;
using SubsonicWS.Jukebox;
using SubsonicWS.MediaAnnotation;
using SubsonicWS.Playlists;
using SubsonicWS.Podcast;
using SubsonicWS.Searching;
using SubsonicWS.Sharing;
using SubsonicWS.SubSystem;
using System;
using System.Collections.Generic;

namespace SubsonicWS.Common
{
    public class Constants
    {
        public const String SubNamespace = "http://subsonic.org/restapi";
        public const String SubResponse = "subsonic-response";

        public static readonly Dictionary<JukeBoxAction, String> JuckeBoxActions = new Dictionary<JukeBoxAction, String>
        {
            {JukeBoxAction.get, "get"},
            {JukeBoxAction.status,"status"},
            {JukeBoxAction.set,"set"},
            {JukeBoxAction.start, "start" },
            {JukeBoxAction.stop, "stop"},
            {JukeBoxAction.skip, "skip" },
            {JukeBoxAction.add, "add" },
            {JukeBoxAction.clear, "clear" },
            {JukeBoxAction.remove, "remove" },
            {JukeBoxAction.shuffle, "shuffle" },
            {JukeBoxAction.setGain, "setGain"}
        };

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
        {typeof(GetRandomSongs),"getRandomSongs.view"},
        {typeof(GetNowPlaying),"getNowPlaying.view"},
        {typeof(GetStarred),"getStarred.view"},
        {typeof(GetStarred2),"getStarred2.view"},
        {typeof(Search),"search.view"},
        {typeof(Search2),"search2.view"},
        {typeof(Search3),"search3.view"},
        {typeof(GetPlaylists),"getPlaylists.view"},
        {typeof(GetPlaylist),"getPlaylist.view"},
        {typeof(CreatePlaylist),"createPlaylist.view"},
        {typeof(UpdatePlaylist),"updatePlaylist.view"},
        {typeof(DeletePlaylist),"deletePlaylist.view"},
        {typeof(Star),"star.view"},
        {typeof(Unstar),"unstar.view"},
        {typeof(SetRating),"setRating.view"},
        {typeof(Scrobble),"scrobble.view"},
        {typeof(GetShares),"getShares.view"},
        {typeof(CreateShare),"createShare.view"},
        {typeof(UpdateShare),"updateShare.view"},
        {typeof(DeleteShare),"deleteShare.view"},
        {typeof(GetPodcasts),"getPodcasts.view"},
        {typeof(JukeboxControl),"jukeboxControl.view"},
        {typeof(GetChatMessages),"getChatMessages.view"},
        {typeof(AddChatMessage),"addChatMessage.view"},
        //{PagesEnumeration.getUser,"getUser.view"},
        //{PagesEnumeration.getUsers,"getUsers.view"},
        //{PagesEnumeration.createUser,"createUser.view"},
        //{PagesEnumeration.deleteUser,"deleteUser.view"},
        //{PagesEnumeration.changePassword,"changePassword.view"}
        };
    }
}