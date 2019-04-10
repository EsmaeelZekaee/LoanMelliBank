using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.People.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.Accounts.Dto
{
    [AutoMapFrom(typeof(Account)), AutoMapTo(typeof(Account))]
    public class AccountDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
    }
}
