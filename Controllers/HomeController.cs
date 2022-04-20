using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectoAvance1.Data;
using ProjectoAvance1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectoAvance1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectDbContext _db;
        public HomeController( ProjectDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias = _db.Categorias.ToList();
            return View(categorias);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
