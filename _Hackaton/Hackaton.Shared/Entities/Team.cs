﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackaton.Shared.Entities
{
    public class Team
    {


        public int ID { get; set; }


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

        [JsonIgnore]
        
        public Hackathon Hackathon { get; set; }
        
        public int? HackathonID { get; set; }

        [JsonIgnore]

        public ICollection<Participant> Participants { get; set; }

        

        





    }
}
