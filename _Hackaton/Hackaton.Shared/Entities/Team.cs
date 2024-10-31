using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Team
    {
        
        
        public int TeamId { get; set; }


        [Display(Name = ("Nombre de equipo"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

        [Display(Name = ("Cantidad de participantes en el equipo"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int memberCount { get; set; }

        [Display(Name = ("Experiencia"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string experience { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]

        [JsonIgnore]
        public HackathonEdition HackathonEdition { get; set; }
        public int IDHackathon { get; set; }

        [JsonIgnore]

        public ICollection<Participant> Participants { get; set; }
        


       

    }
}
