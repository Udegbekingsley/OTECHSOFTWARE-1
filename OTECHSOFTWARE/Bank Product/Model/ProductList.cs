namespace OTECHSOFTWARE.Bank_Product.Model
{
      public class ProductListResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }

}
