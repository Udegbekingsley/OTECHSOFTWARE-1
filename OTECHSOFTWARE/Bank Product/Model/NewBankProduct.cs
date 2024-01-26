namespace OTECHSOFTWARE.Bank_Product.Model
{
    public class NewBankProductRequest
    {
        public string productCode { get; set; }
        public string productName { get; set; }
        public string productGL { get; set; }
        public bool productStatus { get; set; }
    }

    public class NewBankProductResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }
}
