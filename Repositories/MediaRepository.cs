using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backendproject.DataContext;
using backendproject.Models;
using Microsoft.EntityFrameworkCore;

namespace backendproject.Repositories
{
    public interface IMediaRepository
    {
        Task<List<Media>> GetMedias();
        Task<Media> GetMedia(Guid mediaId);
        Task<Media> AddMedia(Media media);
        Task<Media> UpdateMedia(Media media);
        Task<List<Actor>> GetActors();
        Task<Actor> GetActor(Guid actorId);
        Task<Actor> AddActor(Actor actor);
        Task<List<MediaActors>> GetMediaActors(Guid mediaId);
        Task<List<MediaActors>> GetActorMedias(Guid actorId);
    }

    public class MediaRepository : IMediaRepository
    {
        private IMediaContext _context;

        public MediaRepository(IMediaContext context)
        {
            _context = context;
        }

        public async Task<List<Media>> GetMedias()
        {
            return await _context.Medias.ToListAsync();
        }

        public async Task<Media> GetMedia(Guid mediaId)
        {
            Media media = await _context.Medias.Where(e => e.MediaId == mediaId).SingleOrDefaultAsync();
            try
            {
                media.MediaActors = new List<MediaActors>();
                media.MediaActors = await _context.MediaActors.Where(e => e.MediaId == mediaId).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return media;
        }

        public async Task<Media> AddMedia(Media media)
        {
            await _context.Medias.AddAsync(media);
            await _context.SaveChangesAsync();
            return media;
        }

        public async Task<Media> UpdateMedia(Media media)
        {
            Media mediaToUpdate = await _context.Medias.Where(e => e.MediaId == media.MediaId).SingleOrDefaultAsync();
            mediaToUpdate.Name = media.Name;
            mediaToUpdate.Episodes = media.Episodes;
            mediaToUpdate.Length = media.Length;
            mediaToUpdate.Rating = media.Rating;
            mediaToUpdate.ReleaseDate = media.ReleaseDate;
            mediaToUpdate.MediaActors = media.MediaActors;

            return mediaToUpdate;
        }

        public async Task<List<Actor>> GetActors()
        {
            return await _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetActor(Guid actorId)
        {
            return await _context.Actors.Where(e => e.ActorId == actorId).SingleOrDefaultAsync();
        }

        public async Task<Actor> AddActor(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
            return actor;
        }

        public async Task<List<MediaActors>> GetMediaActors(Guid mediaId)
        {
            return await _context.MediaActors.Where(e => e.MediaId == mediaId).ToListAsync();
        }

        public async Task<List<MediaActors>> GetActorMedias(Guid actorId)
        {
            return await _context.MediaActors.Where(e => e.ActorId == actorId).ToListAsync();
        }
    }
}
