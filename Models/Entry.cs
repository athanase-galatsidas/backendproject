using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendproject.Models
{
    public class Entry
    {
        public User User { get; set; }
        public Media Media { get; set; }
        public Guid UserId { get; set; }
        public Guid MediaId { get; set; }

        public string State { get; set; }
        public int EpisodeProgress { get; set; }
        public double Rating { get; set; }
    }
}
