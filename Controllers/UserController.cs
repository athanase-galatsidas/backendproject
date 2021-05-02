using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backendproject.Models;
using backendproject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Routing;

namespace backendproject.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/users")]
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
                return new OkObjectResult(await _userService.GetUsers());
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("{userId}")]
        public async Task<ActionResult<User>> GetUser(Guid userId)
        {
            try
            {
                return new OkObjectResult(await _userService.GetUser(userId));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("adduser")]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            try
            {
                return new OkObjectResult(await _userService.AddUser(user));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("{userId}/entries")]
        public async Task<ActionResult<List<Entry>>> GetUserEntries(Guid userId)
        {
            try
            {
                return new OkObjectResult(await _userService.GetUserEntries(userId));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("addentry")]
        public async Task<ActionResult<Entry>> AddEntry(Entry entry)
        {
            try
            {
                return new OkObjectResult(await _userService.AddEntry(entry));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPut]
        [Route("updateentry")]
        public async Task<ActionResult<Entry>> UpdateEntry(Entry entry)
        {
            try
            {
                return new OkObjectResult(await _userService.UpdateEntry(entry));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
