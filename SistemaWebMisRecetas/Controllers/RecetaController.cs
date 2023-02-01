using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {

        //Inyección de dependencias.

        private readonly RecetasContext context;

        public RecetaController(RecetasContext context)
        {
            this.context = context;
        }

        //GET Receta/index
        [HttpGet]
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }


        //Get: Receta/create
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();

            return View("Create", receta);
        }

        //post: Receta/create
        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        //GET Receta/Details/4
        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = context.Recetas.Find(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }

        }

        //GET Receta/ByNombreAutor/nombreAutor
        [HttpGet("{nombreAutor}")]
        public ActionResult<IEnumerable<Receta>> ByNombreAutor(string NombreAutor)
        {
            var receta = (from a in context.Recetas
                            where a.NombreAutor == NombreAutor
                            select a).ToList();
            return View("ByNombreAutor", receta);

        }


        //GET Receta/ByApellidoAutor/ApellidoAutor
        [HttpGet("/apellido/{apellidoAutor}")]
        public ActionResult<IEnumerable<Receta>> ByApellidoAutor(string ApellidoAutor)
        {
            var receta = (from a in context.Recetas
                          where a.ApellidoAutor == ApellidoAutor
                          select a).ToList();
            return View("ByApellidoAutor", receta);

        }

    }
}
