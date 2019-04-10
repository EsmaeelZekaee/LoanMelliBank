using Abp.AutoMapper;
using LoanMelliBank.LoanInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoanMelliBank.Web.Models.People
{

    [AutoMapTo(typeof(Person))]
    public class CreatePersonModalViewModel
    {
        public CreatePersonModalViewModel()
        {
            AddressInfos = new List<EditOrCreateAddressInfoViewModel>();
        }

        public PersonType PersonType { get; set; }
        [MaxLength(10)]
        public string NationalCode { get; set; }
        [MaxLength(100)]
        public string IdentityCode { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(100)]
        public string CustomerCode { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(11)]
        public string Job { get; set; }
        public IList<EditOrCreateAddressInfoViewModel> AddressInfos { get; set; }
    }
}
