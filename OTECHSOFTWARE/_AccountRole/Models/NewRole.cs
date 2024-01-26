namespace OTECHSOFTWARE._AccountRole.Models
{
    public class NewRoleRequest
    {
        public string title { get; set; }
        public string description { get; set; }
    }
    public class NewRoleResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }

}
