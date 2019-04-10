using Abp.Application.Services.Dto;

namespace LoanMelliBank.People.Dto
{
    public class PagedPeopleResultRequestDto : PagedResultRequestDto, IPagedAndSortedResultRequest
    {
        public string Keyword { get; set; }
        public string Sorting { get; set; }
    }
}

