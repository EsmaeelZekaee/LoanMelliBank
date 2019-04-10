namespace LoanMelliBank.LoanInfo
{
    public class Guarantor : LoanBaseEntity
    {

        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int DisplayOrder { get; set; }
    }
}
