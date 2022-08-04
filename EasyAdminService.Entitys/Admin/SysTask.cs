using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyAdminService.Entitys.Admin
{
    public partial class SysTask
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
        public sbyte Type { get; set; }
        public sbyte Status { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Limit { get; set; }
        public string Cron { get; set; }
        public int? Every { get; set; }
        public string Data { get; set; }
        public string JobOpts { get; set; }
        public string Remark { get; set; }
    }
}
