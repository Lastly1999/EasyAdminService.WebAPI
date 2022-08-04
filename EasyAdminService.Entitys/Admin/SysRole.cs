using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysRole
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Remark { get; set; }
    }
}
