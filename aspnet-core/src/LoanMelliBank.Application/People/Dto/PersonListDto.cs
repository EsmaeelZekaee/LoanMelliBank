﻿using Abp.Application.Services.Dto;
using LoanMelliBank.LoanInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoanMelliBank.People.Dto
{
    public class PersonListDto : EntityDto<int>
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
        public string FullName => $"{FirstName} {LastName}";
    }
}