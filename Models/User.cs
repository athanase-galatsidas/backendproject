using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backendproject.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public List<Entry> Entries { get; set; }
    }
}
