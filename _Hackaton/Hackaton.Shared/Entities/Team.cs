using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Team
    {
        [Display(Name = ("Codigo de equipo"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }

        [Display(Name = ("Nombre de equipo"))]
        [MaxLength(30, ErrorMessage = "El {1} solo puede tener 30 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

        [Display(Name = ("Cantidad de miembros del equipo"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int memberCount { get; set; }

        [Display(Name = ("Experiencia del equipo"))]
        [MaxLength(30, ErrorMessage = "El {4} solo puede tener 30 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string experience { get; set; }

    }
}
