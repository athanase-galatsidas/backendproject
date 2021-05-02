using System;
using System.Collections.Generic;
using System.Linq;
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
            return await _context.Users.Where(e => e.UserId == userId)
            .Include(e => e.Entries)
            .SingleOrDefaultAsync();
        }

        public async Task<User> AddUser(User user)
        {
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
    }
}
