using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backendproject.Models;
using backendproject.Repositories;

namespace backendproject.Services
{
    public interface IMediaService
    {
        Task<List<Media>> GetMedias();
    }

    public class MediaService : IMediaService
    {
        private IMediaRepository _mediaRepository;

        public MediaService(IMediaRepository mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }

        public async Task<List<Media>> GetMedias()
        {
            return await _mediaRepository.GetMedias();
        }
    }
}
