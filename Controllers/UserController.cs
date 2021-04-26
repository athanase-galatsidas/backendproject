using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backendproject.Models;
using backendproject.Services;

namespace backendproject.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            try
            {
                return await _userService.GetUsers();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("users/{userid}")]
        public ActionResult<User> GetUser(Guid userid)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("users/addentry")]
        public ActionResult AddEntry()
        {
            throw new NotImplementedException();
        }
    }
}
