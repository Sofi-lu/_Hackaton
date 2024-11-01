using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Hackaton.Shared.Entities
{
    public class Project
    {
        public int ID { get; set; }

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
        public string dueDate { get; set; }

        [JsonIgnore]

        public Team Team { get; set; }
        public int? TeamID { get; set; }

        [JsonIgnore]

        public ICollection<Assessment> Assessments { get; set; }

        

    }
}
