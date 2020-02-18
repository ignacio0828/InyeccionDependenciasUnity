using DatosAlumnos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatosAlumnos.Controllers
{
    public class HomeController : Controller
    {
        IRepositoryEscuela repo;
        public HomeController(IRepositoryEscuela repo)
        {
            this.repo = repo;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Alumnos()
        {
            return View(this.repo.GetAlumnos());
        }
    }
}