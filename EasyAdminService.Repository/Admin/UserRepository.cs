using EasyAdminService.Entitys;
using EasyAdminService.Entitys.Admin;
using EasyAdminService.Interfaces.Admin.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace EasyAdminService.Repository.Admin
{
    public class UserRepository:IUserRepository
    {

        public SysDataBaseContext sysDataBaseContext;

        public UserRepository(SysDataBaseContext _sysDataBaseContext)
        {
            sysDataBaseContext = _sysDataBaseContext;
        }

        public List<SysUser> GetUserList()
        {
            return sysDataBaseContext.SysUser.ToList();
        }
    }
}
