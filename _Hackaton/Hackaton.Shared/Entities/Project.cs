using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Project
    {
        [Display(Name = ("Codigo del proyecto"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }
        public string description { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        [Display(Name = ("¿Esta listo?"))]
        public string state { get; set; }


        [Required(ErrorMessage = "Es obligatorio")]
        public DateTime dueDate { get; set; }

        public HackathonEdition HackathonEdition { get; set; }

        

    }
}
