using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{

    public class Assessment
    {
        public int assessmentId { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public int Score { get; set; }
        public string Feedback { get; set; }

        [JsonIgnore]
        public Project Project { get; set; }
        public int ProjectId { get; set; }

        [JsonIgnore]
        public Mentor Mentor { get; set; }
        public int MentorId { get; set; }

    }

    
}
