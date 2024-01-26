namespace OTECHSOFTWARE.AccountRoles.Models
{
    public class AddRoleMenusRequest
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<string> menuIds { get; set; }
    }

    public class AddRoleMenusResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }


}
