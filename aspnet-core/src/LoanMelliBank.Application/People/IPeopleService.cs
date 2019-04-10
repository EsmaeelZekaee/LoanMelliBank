using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using LoanMelliBank.Accounts.Dto;
using LoanMelliBank.AddressInfos.Dto;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.Loans.Dto;
using LoanMelliBank.People.Dto;
using LoanMelliBank.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanMelliBank.People
{
    public interface IPeopleAppService
    {
        Task<GetPersonForEditOutput> GetPersonForEditAsync(int id);
        ICollection<LoanDto> GetLoans(int id);
        ICollection<AddressInfoDto> GetAddressInfos(int id);
        ICollection<AccountDto> GetAccounts(int id);
        Task<ListResultDto<PersonListDto>> GetPeopleAsync(PagedPeopleResultRequestDto getRolesInput);
    }

    public class PeopleAppService : AsyncCrudAppService<Person, PersonDto, int, PagedPeopleResultRequestDto, PersonCreateInput, PersonUpdateInput, GetPeopleInput>, IPeopleAppService
    {
        private readonly IRepository<Person, int> _repository;
        private readonly IObjectMapper _objectMapper;

        public PeopleAppService(IRepository<Person, int> repository, IObjectMapper objectMapper) : base(repository)
        {
            this._repository = repository;
            this._objectMapper = objectMapper;
        }

        public ICollection<AccountDto> GetAccounts(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<AddressInfoDto> GetAddressInfos(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<LoanDto> GetLoans(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ListResultDto<PersonListDto>> GetPeopleAsync(PagedPeopleResultRequestDto getPeopleInput)
        {
            var people = await _repository.GetAllListAsync();
            return new ListResultDto<PersonListDto>(_objectMapper.Map<List<PersonListDto>>(people));
        }

      

        public async Task<GetPersonForEditOutput> GetPersonForEditAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
