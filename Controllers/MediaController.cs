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
    [Route("api/media")]
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
            try
            {
                return new OkObjectResult(await _mediaService.GetMedias());
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpGet]
        [Route("{mediaId}")]
        public async Task<ActionResult<Media>> GetMedia(Guid mediaId)
        {
            try
            {
                return new OkObjectResult(await _mediaService.GetMedia(mediaId));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        [Route("addmedia")]
        public async Task<ActionResult<Media>> AddMedia(Media media)
        {
            try
            {
                return new OkObjectResult(await _mediaService.AddMedia(media));
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
