using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.People.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.Guarantors.Dto
{
    [AutoMapFrom(typeof(Guarantor)), AutoMapTo(typeof(Guarantor))]
    public class GuarantorDto : EntityDto<int>
    {
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
        public int LoanId { get; set; }
        public PersonDto Loan { get; set; }
        public int DisplayOrder { get; set; }
    }
}
