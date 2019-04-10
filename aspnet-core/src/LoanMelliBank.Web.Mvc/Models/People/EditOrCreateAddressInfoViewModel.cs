using Abp.AutoMapper;
using LoanMelliBank.LoanInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMelliBank.Web.Models.People
{
    [AutoMapTo(typeof(AddressInfo))]
    public class EditOrCreateAddressInfoViewModel
    {
        public AddressType PlaceType { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public int PersonId { get; set; }
    }
}
