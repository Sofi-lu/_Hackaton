using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class ProjectAward

    { 
        
        public int AwardId { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]

        [JsonIgnore]
        public Project Project { get; set; }
        public int ProjectId { get; set; }

        [JsonIgnore]

        public HackathonEdition HackathonEdition { get; set; }
        public int HackathonId { get; set; }

        


    }
}
