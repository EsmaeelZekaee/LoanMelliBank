using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LoanMelliBank.Accounts.Dto;
using LoanMelliBank.Guarantors.Dto;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.Loans.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.People.Dto
{
    [AutoMapFrom(typeof(Person)), AutoMapTo(typeof(Person))]
    public class PersonDto : EntityDto<int>
    {
        public PersonType PersonType { get; set; }
        public string NationalCode { get; set; }
        public string IdentityCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerCode { get; set; }
        public ICollection<AccountDto> Accounts { get; set; }
        public ICollection<AddressInfo> AddressInfos { get; set; }
        public string Mobile { get; set; }
        public string Job { get; set; }
        public ICollection<LoanDto> Loans { get; set; }
        public ICollection<GuarantorDto> Guarantors { get; set; }
    }
}
