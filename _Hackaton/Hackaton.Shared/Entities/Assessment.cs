using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    
        public class Assessment
        {
            [Display(Name = ("Codigo evaluacion"))]
            [Required(ErrorMessage = "Es obligatorio")]
            public int Id { get; set; }
            public int Score { get; set; }
            public string Feedback { get; set; }
        }
    
}
