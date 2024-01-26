﻿namespace OTECHSOFTWARE.AccountRoles.Models
{
    public class UpdateRoleMenusRequest
    {
        public int roleId { get; set; }
        public List<string> menuIds { get; set; }
    }

    public class UpdateRoleMenusResponse
    {
        public bool succeeded { get; set; }
        public string message { get; set; }
        public object errors { get; set; }
        public object data { get; set; }
    }


}
