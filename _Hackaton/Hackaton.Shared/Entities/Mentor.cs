using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
     public class Mentor
    {
        [Display(Name = ("Identificacion del Mentor"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }


        [Display(Name = ("Nombre del mentor"))]
        [MaxLength(20, ErrorMessage = "El {1} puede tener solo 10 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }


        [Display(Name = ("Experiencia del mentor"))]
        [MaxLength(20, ErrorMessage = "El {2} puede tener solo 10 caracteres")]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Experience { get; set; }
    }
}
