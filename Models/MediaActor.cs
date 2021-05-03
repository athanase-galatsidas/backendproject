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

        [JsonIgnore]
        public Actor Actor { get; set; }
        [JsonIgnore]
        public Media Media { get; set; }
    }
}
