using EasyAdminService.Entitys.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAdminService.Interfaces.Admin.IRepository
{
    public interface IUserRepository
    {
        public List<SysUser> GetUserList();
    }
}
