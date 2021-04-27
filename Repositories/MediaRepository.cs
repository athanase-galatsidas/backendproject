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
            .Include(e => e.Actors)
            .SingleOrDefaultAsync();
        }

        public async Task<Media> AddMedia(Media media)
        {
            await _context.Medias.AddAsync(media);
            await _context.SaveChangesAsync();
            return media;
        }
    }
}
