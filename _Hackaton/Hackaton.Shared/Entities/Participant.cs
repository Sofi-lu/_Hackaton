using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Participant
    {
        public int ID_Participant { get; set; }


        [Display(Name = ("Nombre del participante"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

        [Display(Name = ("Rol del participante"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string role { get; set; }

        [Display(Name = ("Equipo del participante"))]

        [JsonIgnore]
        
        public Team Team { get; set; }
        public int? ID_Team { get; set; }
    }
}
