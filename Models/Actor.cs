using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace backendproject.Models
{
    public class Actor
    {
        [Key]
        public Guid ActorId { get; set; }
        public string Name { get; set; }
        public ICollection<MediaActor> MediaActors { get; set; } = new List<MediaActor>();
    }
}
