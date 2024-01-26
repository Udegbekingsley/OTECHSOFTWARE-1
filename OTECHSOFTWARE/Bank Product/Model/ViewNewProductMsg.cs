namespace OTECHSOFTWARE.Bank_Product.Model
{
  
    public class ViewNewProductMsgrRequest
    {
        public string messageID { get; set; }
    }

    public class ViewNewProductMsgrResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }


}
