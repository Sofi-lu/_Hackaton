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
            public int Id { get; set; }

            [Required(ErrorMessage = "Es obligatorio")]
            public int Score { get; set; }
            public string Feedback { get; set; }

        public Project Project { get; set; }

        public Mentor Mentor { get; set; }
    }

    
}
