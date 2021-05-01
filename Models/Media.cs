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
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public int Episodes { get; set; }
        public double Rating { get; set; }
        public List<MediaActor> MediaActors { get; set; }
    }
}
