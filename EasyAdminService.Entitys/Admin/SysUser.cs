using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysUser
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string HeadImg { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public sbyte? Status { get; set; }
    }
}
