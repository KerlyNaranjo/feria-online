using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPrueba.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ES ARTESANO";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ES USUARIO";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ES ARTESANO";

            return View();
        }
    }
}