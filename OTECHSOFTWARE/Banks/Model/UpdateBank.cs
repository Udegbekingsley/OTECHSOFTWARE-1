namespace OTECHSOFTWARE.Banks.Model
{
   
    public class UpdateBankRequest
    {
        public int bankId { get; set; }
        public string bankCode { get; set; }
    }

    public class UpdateBankRespones
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }

}
