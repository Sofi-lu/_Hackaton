using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Participant
    {
        public int Id { get; set; }


        [Display(Name = ("Nombre del participante"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

        [Display(Name = ("Rol del participante"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string role { get; set; }

        [Display(Name = ("Equipo del participante"))]
        public Team Team { get; set; }
    }
}
