using System;
using System.Collections.Generic;
using AutoMapper;
using backendproject.Models;

namespace backendproject.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Media, MediaDTO>();
        }
    }
}
