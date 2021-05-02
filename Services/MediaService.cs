using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using backendproject.DTO;
using backendproject.Models;
using backendproject.Repositories;

namespace backendproject.Services
{
    public interface IMediaService
    {
        Task<List<Media>> GetMedias();
        Task<Media> GetMedia(Guid mediaId);
        Task<MediaDTO> AddMedia(MediaDTO media);
    }

    public class MediaService : IMediaService
    {
        private IMediaRepository _mediaRepository;
        private IMapper _mapper;

        public MediaService(IMapper mapper, IMediaRepository mediaRepository)
        {
            _mapper = mapper;
            _mediaRepository = mediaRepository;
        }

        public async Task<List<Media>> GetMedias()
        {
            return await _mediaRepository.GetMedias();
        }

        public async Task<Media> GetMedia(Guid mediaId)
        {
            return await _mediaRepository.GetMedia(mediaId);
        }

        public async Task<MediaDTO> AddMedia(MediaDTO media)
        {
            Media newMedia = _mapper.Map<Media>(media);
            newMedia.MediaId = Guid.NewGuid();
            newMedia.MediaActors = new List<MediaActor>();
            await _mediaRepository.AddMedia(newMedia);

            return media;
        }
    }
}
