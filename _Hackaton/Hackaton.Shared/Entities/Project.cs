﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Hackaton.Shared.Entities
{
    public class Project
    { 
        public int Id { get; set; }

        [Display(Name = ("Nombre del proyecto"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public string Name { get; set; }

        [Display(Name = ("descripcion del proyecto"))]
        public string description { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        [Display(Name = ("Estado del proyecto"))]
        public string state { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = ("Fecha de entrega"))]
        [Required(ErrorMessage = "Es obligatorio")]
        public DateTime dueDate { get; set; }

        public HackathonEdition HackathonEdition { get; set; }

        

    }
}
