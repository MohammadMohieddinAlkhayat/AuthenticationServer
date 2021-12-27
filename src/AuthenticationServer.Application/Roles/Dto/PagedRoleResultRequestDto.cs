using Abp.Application.Services.Dto;

namespace AuthenticationServer.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

