using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysMenu
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Router { get; set; }
        public string Perms { get; set; }
        public sbyte Type { get; set; }
        public string Icon { get; set; }
        public int? OrderNum { get; set; }
        public string ViewPath { get; set; }
        public sbyte? Keepalive { get; set; }
        public sbyte? IsShow { get; set; }
    }
}
