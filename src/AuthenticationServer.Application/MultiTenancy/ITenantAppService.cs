using Abp.Application.Services;
using AuthenticationServer.MultiTenancy.Dto;

namespace AuthenticationServer.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

