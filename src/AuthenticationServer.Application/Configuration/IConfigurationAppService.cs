using System.Threading.Tasks;
using AuthenticationServer.Configuration.Dto;

namespace AuthenticationServer.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
