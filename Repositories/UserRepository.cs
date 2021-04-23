using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backendproject.DataContext;
using backendproject.Models;

namespace backendproject.Repositories
{
    public class UserRepository
    {
        private IMediaContext _context;

        public UserRepository(IMediaContext context)
        {
            _context = context;
        }
    }
}
