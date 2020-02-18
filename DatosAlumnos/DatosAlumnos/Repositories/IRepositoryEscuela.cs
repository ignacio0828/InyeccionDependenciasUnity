using DatosAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnos.Repositories
{
    public interface IRepositoryEscuela
    {
        List<Alumno> GetAlumnos();
    }
}
