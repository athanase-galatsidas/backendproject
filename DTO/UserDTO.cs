using System;
using System.Collections.Generic;
using backendproject.Models;

namespace backendproject.DTO
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
