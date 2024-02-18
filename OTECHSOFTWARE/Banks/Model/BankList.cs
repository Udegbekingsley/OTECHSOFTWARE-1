namespace OTECHSOFTWARE.Banks.Model
{
        public class Banks
    {
        public int bankId { get; set; }
        public string bankName { get; set; }
        public string bankCode { get; set; }
    }

    public class BankListsRespones
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public List<string> errors { get; set; } 
        public List<Banks> data { get; set; }
    }

}
