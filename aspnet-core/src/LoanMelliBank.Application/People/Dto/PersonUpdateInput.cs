using Abp.Application.Services.Dto;
using LoanMelliBank.LoanInfo;
using System;
using System.ComponentModel.DataAnnotations;

namespace LoanMelliBank.People.Dto
{
    public class PersonUpdateInput : EntityDto<int>
    {
        public PersonType PersonType { get; set; }
        [MaxLength(10), Required]
        public string NationalCode { get; set; }
        [MaxLength(20)]
        public string IdentityCode { get; set; }
        [MaxLength(100), Required]
        public string FirstName { get; set; }
        [MaxLength(100), Required]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [MaxLength(100)]
        public string CustomerCode { get; set; }
        [MaxLength(11)]
        public string Mobile { get; set; }
        [MaxLength(100)]
        public string Job { get; set; }
    }
}
