using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backendproject.DataContext;
using backendproject.Models;
using Microsoft.EntityFrameworkCore;

namespace backendproject.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
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
            return await _context.Users.ToListAsync();
        }
    }
}
