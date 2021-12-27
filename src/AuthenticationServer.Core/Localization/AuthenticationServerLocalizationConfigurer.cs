using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AuthenticationServer.Localization
{
    public static class AuthenticationServerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AuthenticationServerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AuthenticationServerLocalizationConfigurer).GetAssembly(),
                        "AuthenticationServer.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
