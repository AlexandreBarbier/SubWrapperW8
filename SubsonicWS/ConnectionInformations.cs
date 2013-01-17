using System;

namespace SubsonicWS
{
    public class ConnectionInformations
    {
        private String login;
        private String password;
        private String server;
        private String version;
        private String uniqId;
        private String format;
        private String serverPort;
        private Boolean instanceIsInit;

        public String ServerPort
        {
            get { return serverPort; }
            set { serverPort = value; }
        }

        private static ConnectionInformations instance;

        public String Format
        {
            get { return format; }
            set { format = value; }
        }

        public String UniqId
        {
            get { return uniqId; }
            set { uniqId = value; }
        }

        public String Version
        {
            get { return version; }
            set { version = value; }
        }

        public String Server
        {
            get { return server; }
            set { server = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        private ConnectionInformations()
        {
        }

        public static void initConnection(String login, String password, String server, String serverPort, String version, String uniqId, String format = "")
        {
            if (instance == null)
            {
                instance = new ConnectionInformations()
                {
                    Login = login,
                    Password = password,
                    Server = server,
                    ServerPort = serverPort,
                    Version = version,
                    UniqId = uniqId,
                    Format = format,
                    instanceIsInit = true
                };
            }
            else
            {
                instance.Login = login;
                instance.Password = password;
                instance.Server = server;
                instance.ServerPort = serverPort;
                instance.Version = version;
                instance.UniqId = uniqId;
                instance.Format = format;
                instance.instanceIsInit = true;
            }
        }

        public static String getConnectionString(String page, String otherParam)
        {
            if (instance != null && instance.instanceIsInit)
                return instance.Server + ":" + instance.ServerPort + "/rest/" + page + "?u=" + instance.Login + "&p=" + instance.Password + "&v=" + instance.Version + "&c=" + instance.UniqId + otherParam;
            throw new Exceptions.ConnectionNotInitialiseException("connection is not initialise please call Connection.initConnection()");
        }

        public static ConnectionInformations getInstance()
        {
            if (instance != null)
                return instance;
            return new ConnectionInformations();
        }
    }
}