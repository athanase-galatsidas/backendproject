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
    public class MediaController : ControllerBase
    {
        // testing
        private static List<Media> _medias = new List<Media>();

        public MediaController(ILogger<UserController> logger)
        {
            _medias.Add(new Media()
            {
                MovieId = Guid.NewGuid(),
                Name = "Cool movie",
                Type = "Movie",
                Date = new DateTime(1999, 9, 10),
                Length = 150.0,
                Episodes = 1,
            });
        }


        [HttpGet]
        public ActionResult<List<Media>> GetMedias()
        {
            return _medias;
        }
    }
}
