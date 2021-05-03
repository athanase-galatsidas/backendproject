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
        Task<Media> AddMedia(Media media);
        Task<Media> UpdateMedia(Media media);
        Task<List<Actor>> GetActors();
        Task<Actor> GetActor(Guid actorId);
        Task<Actor> AddActor(Actor actor);
        Task<MediaActors> AddActorMedia(MediaActors mediaActors);
        Task<List<MediaActors>> GetMediaActors(Guid mediaId);
        Task<List<MediaActors>> GetActorMedias(Guid actorId);
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

        public async Task<Media> AddMedia(Media media)
        {
            // Media newMedia = _mapper.Map<Media>(media);
            // newMedia.MediaId = Guid.NewGuid();
            // newMedia.MediaActors = new List<MediaActor>();
            // await _mediaRepository.AddMedia(newMedia);
            // return media;

            return await _mediaRepository.AddMedia(media);
        }

        public async Task<Media> UpdateMedia(Media media)
        {
            return await _mediaRepository.UpdateMedia(media);
        }

        public async Task<List<Actor>> GetActors()
        {
            return await _mediaRepository.GetActors();
        }

        public async Task<Actor> GetActor(Guid actorId)
        {
            return await _mediaRepository.GetActor(actorId);
        }

        public async Task<Actor> AddActor(Actor actor)
        {
            return await _mediaRepository.AddActor(actor);
        }

        public async Task<MediaActors> AddActorMedia(MediaActors mediaActors)
        {
            return await _mediaRepository.AddActorMedia(mediaActors);
        }

        public async Task<List<MediaActors>> GetMediaActors(Guid mediaId)
        {
            return await _mediaRepository.GetMediaActors(mediaId);
        }

        public async Task<List<MediaActors>> GetActorMedias(Guid actorId)
        {
            return await _mediaRepository.GetActorMedias(actorId);
        }
    }
}
