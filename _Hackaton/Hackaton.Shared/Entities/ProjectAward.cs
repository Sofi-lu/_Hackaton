using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class ProjectAward

    { 
        
        public int ID { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public string Description { get; set; }


        [JsonIgnore]
        
        public Project Project { get; set; }
        public int ProjectID { get; set; }

        [JsonIgnore]
        public Hackathon Hackathon { get; set; }
        public int? HackathonID { get; set; }

        


    }
}
