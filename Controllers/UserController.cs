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
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private static List<User> _users = new List<User>();

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;

            _users.Add(new User()
            {
                UserId = new Guid(),
                Name = "bob",
                Email = "user@email.com",
                Password = "1234",
                IsAdmin = false,
                Entries = new List<Entry>()
            });
        }


        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            try
            {
                return new OkObjectResult(_users);
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
