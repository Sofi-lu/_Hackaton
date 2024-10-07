﻿using System;
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
        [Display(Name = ("Codigo de la puntuación"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public int Id { get; set; }


        public string description { get; set; }
    }
}