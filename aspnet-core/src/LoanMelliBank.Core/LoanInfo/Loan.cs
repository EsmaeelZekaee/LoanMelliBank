using System.Collections.Generic;

namespace LoanMelliBank.LoanInfo
{
    public class Loan : LoanBaseEntity
    {
        public string LoanAlgorithName { get; set; }
        public decimal Ammont { get; set; }
        public float BankShare { get; set; }
        public float InterestRate { get; set; }
        public int LoanPeriod { get; set; }
        public int PaymentPeriod { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<Guarantor> Guarantors { get; set; }
    }
}
