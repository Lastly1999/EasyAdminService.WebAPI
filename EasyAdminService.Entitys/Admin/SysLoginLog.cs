using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysLoginLog
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Ip { get; set; }
        public DateTime? Time { get; set; }
        public string Ua { get; set; }
    }
}
