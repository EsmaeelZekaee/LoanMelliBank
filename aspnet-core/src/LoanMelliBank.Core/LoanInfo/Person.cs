using Abp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LoanMelliBank.LoanInfo
{
    public class Person : LoanBaseEntity
    {
        public PersonType PersonType { get; set; }
        public string NationalCode { get; set; }
        public string CustomerCode { get; set; }
        public NaturalPerson NaturalPerson { get; set; }
        public LegalPerson LegalPerson { get; set; }
        public ICollection<Account> Accounts { get; set; }
        public ICollection<AddressInfo> AddressInfos { get; set; }
        public ICollection<Loan> Loans { get; set; }
        public ICollection<Guarantor> Guarantors { get; set; }
    }

    public abstract class ExtendedPerson : Entity<int>
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }

    public class NaturalPerson : ExtendedPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthCity { get; set; }
        public string Mobile { get; set; }
        public string Job { get; set; }
        public string IdCardCode { get; set; }
        public string IdCardSerialNumber { get; set; }
    }

    public class LegalPerson : ExtendedPerson
    {
        public string Name { get; set; }
        public string RegistrationCode { get; set; }
        public string RegistrationCity { get; set; }
        public DateTime? RegistratedOn { get; set; }
        LegalPersonType LegalPersonType { get; set; }
        public string Coding { get; set; }
        public string ExpirationDate { get; set; }
        public string RegisteredCapital { get; set; }
        public ICollection<BoardOfDirector> BoardofDirectors { get; set; }
        public ICollection<AuthorizedSignatorie> AuthorizedSignatories { get; set; }


    }
    public class BoardOfDirector : Entity<int>
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int LegalPersonId { get; set; }
        public LegalPerson LegalPerson { get; set; }
    }
    public class AuthorizedSignatorie : Entity<int>
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int LegalPersonId { get; set; }
        public LegalPerson LegalPerson { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

    public enum LegalPersonType
    {
        PrivateLimitedCompany = 10,
        NonPublicCompany = 20,
        PublicCompany = 30,
    }
}
