namespace OTECHSOFTWARE.Bank_Product.Model
{
    public class DeactivateBankProductRequest
    {
        public int productID { get; set; }
        public bool productStatus { get; set; }
    }
    public class DeactivateBankProductResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }

}
