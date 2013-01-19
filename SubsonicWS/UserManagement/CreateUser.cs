using SubsonicWS.Common;
using SubsonicWS.Exceptions;
using System;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SubsonicWS.UserManagement
{
    [XmlRoot(Constants.SubResponse, Namespace = Constants.SubNamespace)]
    public class CreateUser : Response<CreateUser>
    {
        /*  username 	Yes 		The name of the new user.
            password 	Yes 		The password of the new user, either in clear text of hex-encoded (see above).
            email 	Yes 		The email address of the new user.
            ldapAuthenticated 	No 	false 	Whether the user is authenicated in LDAP.
            adminRole 	No 	false 	Whether the user is administrator.
            settingsRole 	No 	true 	Whether the user is allowed to change settings and password.
            streamRole 	No 	true 	Whether the user is allowed to play files.
            jukeboxRole 	No 	false 	Whether the user is allowed to play files in jukebox mode.
            downloadRole 	No 	false 	Whether the user is allowed to download files.
            uploadRole 	No 	false 	Whether the user is allowed to upload files.
            playlistRole 	No 	false 	Whether the user is allowed to create and delete playlists. Since 1.8.0, changing this role has no effect.
            coverArtRole 	No 	false 	Whether the user is allowed to change cover art and tags.
            commentRole 	No 	false 	Whether the user is allowed to create and edit comments and ratings.
            podcastRole 	No 	false 	Whether the user is allowed to administrate Podcasts.
            shareRole 	No 	false 	(Since 1.8.0)Whether the user is allowed to share files with anyone.*/

        public async Task Request(String username, String password, String email, Boolean ldapAuthenticated = false, Boolean adminRole = false, Boolean settingsRole = false,
            Boolean streamRole = false, Boolean jukeboxRole = false, Boolean downloadRole = false, Boolean uploadRole = false, Boolean playlistRole = false,
            Boolean coverArtRole = false, Boolean commentRole = false, Boolean podcastRole = false, Boolean shareRole = false)
        {
            String otherParam = "&username=" + username + "&password=" + password + "&email=" + email;
            otherParam += "&ldapAuthenticated=" + ldapAuthenticated + "&adminRole=" + adminRole;
            otherParam += "&settingsRole=" + settingsRole + "&jukeboxRole=" + jukeboxRole;
            otherParam += "&downloadRole=" + downloadRole + "&uploadRole=" + uploadRole;
            otherParam += "&playlistRole=" + playlistRole + "&coverArtRole=" + coverArtRole;
            otherParam += "&commentRole=" + commentRole + "&podcastRole=" + podcastRole;
            if (shareRole)
                otherParam += "&shareRole=" + shareRole;
            CreateUser item = await Get(otherParam);
            if (item.StatusValue == ResponseStatus.Failed)
                throw new ResponseStatusFailedException("Create User failed", item.Error);
            this.Copy(item);
        }
    }
}