using Abp.Application.Services.Dto;

namespace LoanMelliBank.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

