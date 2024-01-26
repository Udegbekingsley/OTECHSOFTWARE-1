namespace OTECHSOFTWARE.Bank_Product.Model
{
      public class ApproveDeclineDeactivateProductRequest
    {
        public string messageID { get; set; }
        public int msgCommand { get; set; }
    }

    public class ApproveDeclineDeactivateProductResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }
}
