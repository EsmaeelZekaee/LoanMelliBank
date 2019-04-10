using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LoanMelliBank.LoanInfo;
using LoanMelliBank.People.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoanMelliBank.AddressInfos.Dto
{
    [AutoMapFrom(typeof(AddressInfo)), AutoMapTo(typeof(AddressInfo))]
    public class AddressInfoDto : EntityDto<int>
    {
        public AddressType PlaceType { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
    }
}
