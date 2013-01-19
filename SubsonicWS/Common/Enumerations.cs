namespace SubsonicWS.Common
{
    public enum ResponseStatus
    {
        Ok,
        Failed
    }

    /*get, status (since 1.7.0), set (since 1.7.0), start, stop, skip, add, clear, remove, shuffle, setGain*/

    public enum JukeBoxAction
    {
        get,
        status,
        set,
        start,
        stop,
        skip,
        add,
        clear,
        remove,
        shuffle,
        setGain
    }

    public enum AlbumListTypeEnum
    {
        random,
        newest,
        highest,
        frequent,
        recent,
        alphabeticalByName,
        alphabeticalByArtist,
        starred
    }

    /*
     * 0 	A generic error.
     * 10 	Required parameter is missing.
     * 20 	Incompatible Subsonic REST protocol version. Client must upgrade.
     * 30 	Incompatible Subsonic REST protocol version. Server must upgrade.
     * 40 	Wrong username or password.
     * 50 	User is not authorized for the given operation.
     * 60 	The trial period for the Subsonic server is over. Please donate to get a license key. Visit subsonic.org for details.
     * 70 	The requested data was not found.
     */

    public enum ErrorCode
    {
        Generic = 0,
        MissingRequiredParameter = 10,
        ClientMustUpgrade = 20,
        ServerMustUpgrade = 30,
        WrongCredential = 40,
        UserRight = 50,
        TrialEnded = 60,
        RequestedDataNotFound = 70
    }
}