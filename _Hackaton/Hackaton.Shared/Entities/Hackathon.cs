using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Hackathon
    {
        
        public int ID { get; set; }
        public String StartDate { get; set; }
        public String EndDate { get; set; }

        [Display(Name = ("Nombre de la edicion de la hackaton"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }


        [Display(Name = ("Tematica de la edicion de la hackaton"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string topic { get; set; }

        [Display(Name = ("Organizador a cargo de la edicion de la hackaton"))]
        [Required(ErrorMessage = "Es obligatorio")]
        
        public string organizer { get; set; }

        [JsonIgnore]
        public ICollection<Team> Teams { get; set; }
        [JsonIgnore]
        public ICollection<ProjectAward> Awards { get; set; }
        [JsonIgnore]
        public ICollection<Mentor> Mentors { get; set; }

    }
}
