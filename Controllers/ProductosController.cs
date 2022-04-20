using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectoAvance1.Data;
using ProjectoAvance1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectoAvance1.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly ProjectDbContext _db;
        public ProductosController(ProjectDbContext db)
        {
            _db = db;
        }
        // GET: ProductosController
        public ActionResult Index(string buscadorCat)
        {
            //Listar Categorias para llenar desplegable
            List<Categoria> categorias = new List<Categoria>();
            categorias = _db.Categorias.ToList();

            //Mandar resultado a VieBag
            ViewBag.Categorias = categorias;

            List<Producto> productos = new List<Producto>();
            //Filtrar productos si buscador viene con valor o es nulo
            if (!String.IsNullOrEmpty(buscadorCat))
            {
                productos = _db.Productos.Where(p => p.IdCategoria == Convert.ToInt32(buscadorCat)).ToList();
            }
            else
            {
                productos = _db.Productos.ToList();
            }

            return View(productos);
        }

        // GET: ProductosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
