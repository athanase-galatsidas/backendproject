using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backendproject.Models;

namespace backendproject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> _users = new List<User>();

        public UserController(ILogger<UserController> logger)
        {
            _users.Add(new User()
            {
                UserId = new Guid(),
                Name = "bob",
                Email = "user@email.com",
                Password = "1234",
                IsAdmin = false,
            });
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return _users;
        }
    }
}
