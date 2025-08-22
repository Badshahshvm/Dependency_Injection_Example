using Dependency_Injection_Example.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //UserService userService;
        ////public UserController() { 
        ////userService = new UserService();
        ////}

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getUsername")]
        public IActionResult GetUsername()
        {
            return Ok(_userService.GetUserName());
        }

        [HttpGet("getUserId")]
        public IActionResult GetUserId()
        {
           
            return Ok(_userService.GetUserId());
        }

        [HttpGet("getUserRole")]
        public IActionResult GetUserRole()
        {
            return Ok(_userService.GetUserRole());
        }
    }
}
