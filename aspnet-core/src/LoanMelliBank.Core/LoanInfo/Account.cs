namespace LoanMelliBank.LoanInfo
{
    public class Account : LoanBaseEntity
    {
        public string Code { get; set; }
        public string BankName { get; set; }
        public string BranchCode { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
