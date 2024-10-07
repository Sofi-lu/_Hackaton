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

        [Display(Name = ("Identificacion del participante"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }


       
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }



        
        [Required(ErrorMessage = "Es obligatorio")]
        public string role { get; set; }

        public Team Team { get; set; }
    }
}
