using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.People.Dto
{
    public class GetPeopleInput :  EntityDto<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string Mobile { get; set; }
        public string CutomerCode { get; set; }
    }
}
