using SubsonicWS.UserManagement;
using System;
using System.Threading.Tasks;

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

        /// <summary>
        /// Inits the connection.
        /// </summary>
        /// <param name="login">The login.</param>
        /// <param name="password">The password.</param>
        /// <param name="server">The server.</param>
        /// <param name="serverPort">The server port.</param>
        /// <param name="version">The version.</param>
        /// <param name="uniqId">The uniq id.</param>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        /// <exception cref="SubsonicWS.Exceptions.InvalidUserNameOrPasswordException"></exception>
        public static async Task initConnection(String login, String password, String server, String serverPort, String version, String uniqId, String format = "")
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
            GetUser u = new GetUser();
            try
            {
                await u.Request(login);
            }
            catch (Exceptions.ResponseStatusFailedException e)
            {
                if (e.error.Code == 40)
                    throw new Exceptions.InvalidUserNameOrPasswordException(e.error.Message);
                else if (e.error.Code == 60)
                    throw new Exceptions.TrialPeriodeEndedException(e.error.Message);
                else
                    throw e;
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