using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysReqLog
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Ip { get; set; }
        public int? UserId { get; set; }
        public string Params { get; set; }
        public string Action { get; set; }
        public string Method { get; set; }
        public int? Status { get; set; }
        public int? ConsumeTime { get; set; }
    }
}
