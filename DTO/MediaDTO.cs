using System;
using System.Collections.Generic;
using backendproject.Models;

namespace backendproject.DTO
{
    public class MediaDTO
    {
        public Guid MediaId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Length { get; set; }
        public int Episodes { get; set; }
        public double Rating { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
