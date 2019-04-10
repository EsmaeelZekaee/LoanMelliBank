using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LoanMelliBank.Guarantors.Dto;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.People.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.Loans.Dto
{
    [AutoMapFrom(typeof(Loan)), AutoMapTo(typeof(Loan))]
    public class LoanDto : EntityDto<int>
    {
        public string LoanAlgorithName { get; set; }
        public decimal Ammont { get; set; }
        public float BankShare { get; set; }
        public float InterestRate { get; set; }
        public int LoanPeriod { get; set; }
        public int PaymentPeriod { get; set; }
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
        public ICollection<GuarantorDto> Guarantors { get; set; }
        public LoanDto()
        {
            Guarantors = new List<GuarantorDto>();
        }
    }
}
