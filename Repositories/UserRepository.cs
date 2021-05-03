using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using backendproject.DataContext;
using backendproject.Models;
using Microsoft.EntityFrameworkCore;

namespace backendproject.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid userId);
        Task<List<Entry>> GetUserEntries(Guid userId);
        Task<User> AddUser(User user);
        Task<Entry> AddEntry(Entry entry);
        Task<Entry> UpdateEntry(Entry entry);
        Task<Entry> DeleteEntry(Entry entry);
    }

    public class UserRepository : IUserRepository
    {
        private IMediaContext _context;

        public UserRepository(IMediaContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.Include(e => e.Entries).ToListAsync();
        }

        public async Task<User> GetUser(Guid userId)
        {
            User user = await _context.Users.Where(e => e.UserId == userId).SingleOrDefaultAsync();
            user.Entries = await _context.Entries.Where(e => e.UserId == userId).ToListAsync();
            return user;
        }

        public async Task<User> AddUser(User user)
        {
            // store the user
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Entry> AddEntry(Entry entry)
        {
            await _context.Entries.AddAsync(entry);
            await _context.SaveChangesAsync();
            return entry;
        }

        public async Task<List<Entry>> GetUserEntries(Guid userId)
        {
            return await _context.Entries.Where(e => e.UserId == userId).ToListAsync();
        }

        public async Task<Entry> UpdateEntry(Entry entry)
        {
            Entry entryToUpdate = await _context.Entries.Where(e => e.MediaId == entry.MediaId && e.UserId == entry.UserId).SingleOrDefaultAsync();

            entryToUpdate.EpisodeProgress = entry.EpisodeProgress;
            entryToUpdate.Rating = entry.Rating;
            entryToUpdate.State = entry.State;

            await _context.SaveChangesAsync();
            return entryToUpdate;
        }

        public async Task<Entry> DeleteEntry(Entry entry)
        {
            Entry entryToDelete = await _context.Entries.Where(e => e.MediaId == entry.MediaId && e.UserId == entry.UserId).SingleOrDefaultAsync();
            _context.Entries.Remove(entryToDelete);

            await _context.SaveChangesAsync();
            return entryToDelete;
        }
    }
}
