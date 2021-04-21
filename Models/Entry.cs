using System;

namespace backendproject.Models
{
    public class Entry
    {
        public Media Media { get; set; }
        public User User { get; set; }

        public string State { get; set; }
        public int EpisodeProgress { get; set; }
        public double Rating { get; set; }
    }
}
