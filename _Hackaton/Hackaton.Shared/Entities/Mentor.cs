using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
     public class Mentor
    {
        public int ID{ get; set; }


        [Display(Name = ("Nombre del mentor"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }


        [Display(Name = ("Experiencia del mentor"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Experience { get; set; }

        [JsonIgnore]
        
        public Hackathon Hackathon { get; set; }
        public int? HackathonID { get; set;}    

        [JsonIgnore]
        public ICollection<Assessment> Assessments { get; set; }
    }
}
