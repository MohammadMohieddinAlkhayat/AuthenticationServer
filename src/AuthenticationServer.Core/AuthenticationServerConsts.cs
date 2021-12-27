using AuthenticationServer.Debugging;

namespace AuthenticationServer
{
    public class AuthenticationServerConsts
    {
        public const string LocalizationSourceName = "AuthenticationServer";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "436f4db4e7484cf09f75fc84df868fb6";
    }
}
