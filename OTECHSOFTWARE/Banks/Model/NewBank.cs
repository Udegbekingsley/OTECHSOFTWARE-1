namespace OTECHSOFTWARE.Banks.Model
{
   
    public class NewBankRequest
    {
        public string bankName { get; set; }
        public string bankCode { get; set; }
    }

    public class NewBankResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }

}
