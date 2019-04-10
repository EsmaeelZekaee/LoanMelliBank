namespace LoanMelliBank.LoanInfo
{
    public class AddressInfo : LoanBaseEntity
    {
        public AddressType PlaceType { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
