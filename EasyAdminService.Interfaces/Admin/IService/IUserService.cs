using EasyAdminService.Entitys.Admin;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAdminService.Interfaces.Admin.IService
{
    public interface IUserService
    {
        public List<SysUser> List();
    }
}
