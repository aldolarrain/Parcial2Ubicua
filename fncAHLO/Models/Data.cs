using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace fncAHLO.Models
{
    class Data
    {
        [Key]
        public string Estudiante { get; set; }
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime HoraYFecha { get; set; }
        [Required]
        public string Temperatura { get; set; }
    }
}
