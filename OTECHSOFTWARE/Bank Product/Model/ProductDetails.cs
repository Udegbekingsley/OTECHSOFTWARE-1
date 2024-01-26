namespace OTECHSOFTWARE.Bank_Product.Model
{
    public class ProductDetailsRequest
    {
        public int productID { get; set; }
    }

    public class ProductDetailsResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }
}
