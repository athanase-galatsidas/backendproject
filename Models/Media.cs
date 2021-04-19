using System;

namespace backendproject.Models
{
    public class Media
    {
        public Guid MovieId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public double Length { get; set; }
        public int Episodes { get; set; }
    }
}
