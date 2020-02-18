using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DatosAlumnos.Models;

namespace DatosAlumnos.Data
{
    public class ContextoEscuelaSql : DbContext, IContextoEscuela
    {
        public ContextoEscuelaSql() : base("name=conexionescuelasql") { }

        public DbSet<Alumno> Alumnos { get; set; }
    }
}