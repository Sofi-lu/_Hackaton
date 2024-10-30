using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class ProjectAward

    { 
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public Project Project { get; set; }
    }
}
