using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography;
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
        Task<Entry> UpdateEntry(Entry entry);
        Task<Entry> DeleteEntry(Entry entry);
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
            return await _userRepository.AddUser(user);
        }

        public async Task<Entry> AddEntry(Entry entry)
        {
            return await _userRepository.AddEntry(entry);
        }

        public async Task<Entry> UpdateEntry(Entry entry)
        {
            return await _userRepository.UpdateEntry(entry);
        }

        public async Task<List<Entry>> GetUserEntries(Guid userId)
        {
            return await _userRepository.GetUserEntries(userId);
        }

        public async Task<Entry> DeleteEntry(Entry entry)
        {
            return await _userRepository.DeleteEntry(entry);
        }
    }
}
