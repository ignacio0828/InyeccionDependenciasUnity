using DatosAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnos.Data
{
    public interface IContextoEscuela
    {
        //REFERENCIAMOS LOS METODOS
        DbSet<Alumno> Alumnos { get; set; }
    }
}
