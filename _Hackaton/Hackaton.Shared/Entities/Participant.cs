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


        [Display(Name = ("Nombre del participante"))]
        [MaxLength(20, ErrorMessage = "El {1} puede tener solo 20 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }



        [Display(Name = ("Rol del participante"))]
        [MaxLength(20, ErrorMessage = "El {2} puede tener solo 20 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string role { get; set; }
    }
}
