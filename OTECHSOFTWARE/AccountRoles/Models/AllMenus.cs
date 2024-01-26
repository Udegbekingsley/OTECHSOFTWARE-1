using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OTECHSOFTWARE.AccountRoles.Models
{
    public class Menu
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string url { get; set; }
        public int parentId { get; set; }
        public bool isMenuItem { get; set; }
    }

    public class AllMenusResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public List<Datum> data { get; set; }
    }

}
