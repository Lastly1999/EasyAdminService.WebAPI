using EasyAdminService.Interfaces.Admin.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyAdminService.Hostd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }


        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(userService.List());
        }
    }
}
