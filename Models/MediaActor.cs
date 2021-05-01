using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace backendproject.Models
{
    public class MediaActor
    {
        public Guid MediaId { get; set; }
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
