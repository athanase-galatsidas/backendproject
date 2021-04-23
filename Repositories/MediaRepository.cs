using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backendproject.DataContext;
using backendproject.Models;
using Microsoft.EntityFrameworkCore;

namespace backendproject.Repositories
{
    public interface IMediaRepository
    {
        Task<List<Media>> GetMedias();
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
    }
}
