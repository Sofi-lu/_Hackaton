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
        
        
        public int Id { get; set; }


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
        public Project Project { get; set; }

       

    }
}
