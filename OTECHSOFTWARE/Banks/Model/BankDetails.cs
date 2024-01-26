namespace OTECHSOFTWARE.Banks.Model
{
    
    public class BankDetailsRequest
    {
        public int bankId { get; set; }
    }

    public class BankDetailsRespones
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }
}
