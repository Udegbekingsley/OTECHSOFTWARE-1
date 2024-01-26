namespace OTECHSOFTWARE._AccountRole.Models
{
    public class Role
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }

    public class AllRolesResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public List<Role> data { get; set; }
    }

}
