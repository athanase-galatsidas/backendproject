using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using backendproject.Models;
using backendproject.Repositories;

namespace backendproject.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(Guid userId);
        Task<List<Entry>> GetUserEntries(Guid userId);
        Task<User> AddUser(User user);
        Task<Entry> AddEntry(Entry entry);
    }

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> GetUser(Guid userId)
        {
            return await _userRepository.GetUser(userId);
        }

        public async Task<User> AddUser(User user)
        {
            user.UserId = Guid.NewGuid();
            user.Entries = new List<Entry>();
            user.IsAdmin = false;
            return await _userRepository.AddUser(user);
        }

        public async Task<Entry> AddEntry(Entry entry)
        {
            return await _userRepository.AddEntry(entry);
        }

        public async Task<List<Entry>> GetUserEntries(Guid userId)
        {
            return await _userRepository.GetUserEntries(userId);
        }
    }
}
