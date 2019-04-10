using LoanMelliBank.LoanInfo;
using System;

namespace LoanMelliBank.People.Dto
{
    public class GetPersonForEditOutput
    {
        public PersonType PersonType { get; set; }
        public string NationalCode { get; set; }
        public string IdentityCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CustomerCode { get; set; }
        public string Mobile { get; set; }
        public string Job { get; set; }
    }
}
