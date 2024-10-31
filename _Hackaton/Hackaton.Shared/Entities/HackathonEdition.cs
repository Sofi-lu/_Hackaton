using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class HackathonEdition
    {
        [Display(Name = ("Codigo de la edicion de la hackaton"))]
        public int HackathonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

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
        public ICollection<ProjectAward> Awards { get; set; }
        public ICollection<Mentor> Mentors { get; set; }

    }
}
