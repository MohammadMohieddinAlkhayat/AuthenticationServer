using System.Threading.Tasks;
using Abp.Application.Services;
using AuthenticationServer.Sessions.Dto;

namespace AuthenticationServer.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
