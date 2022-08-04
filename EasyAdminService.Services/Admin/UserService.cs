using EasyAdminService.Entitys.Admin;
using EasyAdminService.Interfaces.Admin.IRepository;
using EasyAdminService.Interfaces.Admin.IService;
using System;
using System.Collections.Generic;

namespace EasyAdminService.Services.Admin
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public List<SysUser> List()
        {
            return userRepository.GetUserList();
        }
    }
}
