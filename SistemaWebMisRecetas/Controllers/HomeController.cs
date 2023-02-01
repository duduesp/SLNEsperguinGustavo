using System;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido Mis Recetas";
            return View();
        }
    }
}
