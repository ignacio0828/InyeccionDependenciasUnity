using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatosAlumnos.Data;
using DatosAlumnos.Models;

namespace DatosAlumnos.Repositories
{
    public class RepositoryEscuela : IRepositoryEscuela
    {
        IContextoEscuela context;

        public RepositoryEscuela(IContextoEscuela context)
        {
            this.context = context;
        }
        public List<Alumno> GetAlumnos()
        {
            return this.context.Alumnos.ToList();
        }
    }
}