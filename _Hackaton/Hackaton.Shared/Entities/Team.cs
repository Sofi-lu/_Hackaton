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

        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

       
        [Required(ErrorMessage = "Es obligatorio")]
        public int memberCount { get; set; }

        
        [Required(ErrorMessage = "Es obligatorio")]
        public string experience { get; set; }

        public Project Project { get; set; }

       

    }
}
