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
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public int Episodes { get; set; }
        // public List<Actor> Actors { get; set; }
    }
}
