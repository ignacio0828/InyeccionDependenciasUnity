using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DatosAlumnos.Models;
using MySql.Data.Entity;

namespace DatosAlumnos.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ContextoEscuelaMySql : DbContext, IContextoEscuela
    {
        public ContextoEscuelaMySql() : base("name=conexiontiendamysql") { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}