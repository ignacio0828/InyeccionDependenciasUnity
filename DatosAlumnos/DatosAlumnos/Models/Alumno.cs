using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatosAlumnos.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        [Column("Codigo")]
        public int Codigo { get; set; }
        [Column("Apellidos")]
        public String Apellidos { get; set; }
        [Column("Nombre")]
        public String Nombre { get; set; }
        [Column("Edad")]
        public int Edad { get; set; }
        [Column("Grado")]
        public int Grado { get; set; }
        [Column("NotaMedia")]
        public decimal Nota {get; set;}
               
    }
}