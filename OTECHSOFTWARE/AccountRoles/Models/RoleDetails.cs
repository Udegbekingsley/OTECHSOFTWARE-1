namespace OTECHSOFTWARE.AccountRoles.Models
{
    public class RoleDetailsRequest
    {
        public int roleId { get; set; }
    }
    public class RoleDetailsResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }


}
