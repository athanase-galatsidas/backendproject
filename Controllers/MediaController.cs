using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backendproject.Models;
using Microsoft.AspNetCore.Routing;
using backendproject.DataContext;
using backendproject.Services;

namespace backendproject.Controllers
{
    [ApiController]
    [Route("media")]
    public class MediaController : ControllerBase
    {
        private readonly IMediaService _mediaService;
        private readonly ILogger<MediaController> _logger;

        public MediaController(IMediaService mediaService, ILogger<MediaController> logger)
        {
            _mediaService = mediaService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Media>>> GetMedias()
        {
            return await _mediaService.GetMedias();
        }

        [HttpGet]
        [Route("media/{mediaid}")]
        public ActionResult<Media> GetMedia(Guid mediaid)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("media/addmedia")]
        public ActionResult AddMedia()
        {
            // todo: only admin can add media
            throw new NotImplementedException();
        }
    }
}
