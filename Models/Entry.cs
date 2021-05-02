using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace backendproject.Models
{
    public class Entry
    {
        [JsonIgnore]
        public User User { get; set; }
        [JsonIgnore]
        public Media Media { get; set; }

        public Guid UserId { get; set; }
        public Guid MediaId { get; set; }

        public string State { get; set; }
        public int EpisodeProgress { get; set; }
        public double Rating { get; set; }
    }
}
