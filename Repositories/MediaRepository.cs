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
        Task<List<Actor>> GetActors();
        Task<Actor> GetActor(Guid actorId);
        Task<Actor> AddActor(Actor actor);
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
            return await _context.Medias.Where(e => e.MediaId == mediaId)
            .Include(e => e.MediaActors)
            .SingleOrDefaultAsync();
        }

        public async Task<Media> AddMedia(Media media)
        {
            await _context.Medias.AddAsync(media);
            await _context.SaveChangesAsync();
            return media;
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
    }
}
