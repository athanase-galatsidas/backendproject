using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backendproject.Models
{
    public class Media
    {
        [Key]
        public Guid MediaId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public int Episodes { get; set; }
        [Range(0, 10)]
        public double Rating { get; set; }
        public ICollection<MediaActor> MediaActors { get; set; } = new List<MediaActor>();
    }
}
