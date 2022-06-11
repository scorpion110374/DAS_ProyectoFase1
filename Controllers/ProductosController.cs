using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectoAvance1.Data;
using ProjectoAvance1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList;

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
        public ActionResult Index(int? page = 1,string buscadorCat = null, string buscadorProd = null)
        {
            //Paginacion
            var pageNumber = page ?? 1;
            int pageSize = 6;

            //Listar Categorias para llenar desplegable
            List<Categoria> categorias = new List<Categoria>();
            categorias = _db.Categorias.ToList();

            //Mandar resultado a VieBag
            ViewBag.Categorias = categorias;

            //id de usuario registrado
            ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //List<Producto> productos = new List<Producto>();
            //Filtrar productos si buscador viene con valor o es nulo
            if (!String.IsNullOrEmpty(buscadorCat))
            {
                ViewBag.Productos = _db.Productos.Where(p => p.IdCategoria == Convert.ToInt32(buscadorCat)).ToPagedList(pageNumber,pageSize);
            }
            else if (!String.IsNullOrEmpty(buscadorProd))
            {
                ViewBag.Productos = _db.Productos.Where(p => p.Descripcion.Contains(buscadorProd)).ToPagedList(pageNumber, pageSize);
            }
            else
            {
                ViewBag.Productos = _db.Productos.ToPagedList(pageNumber,pageSize);
            }

            return View();
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

        //Carrito de Compras
        public ActionResult Carrito()
        {
            return View();
        }

        //Visualizar página de pago(checkout)
        public ActionResult Checkout()
        {
            //id de usuario registrado
            ViewBag.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View();
        }

        // POST: Página de pago(checkout)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout(IFormCollection collection)
        {
            //Grabar venta
            Venta nuevaVenta = new Venta
            {
                Norden = null,
                Fecha = Convert.ToDateTime(collection["Fecha"]),
                IdUsuario = User.FindFirstValue(ClaimTypes.NameIdentifier),
                Nombre = collection["Nombre"],
                Apellido = collection["Apellido"],
                Email = collection["Email"],
                Direccion = collection["Direccion"],
                Direccion2 = collection["Direccion2"],
                Telefono = collection["Telefono"],
                Pais = collection["Pais"],
                Departamento = collection["Departamento"],
                CodigoPostal = collection["CodigoPostal"],
                TipoPago = collection["paymentMethod"],
                Cc_name = collection["Cc_name"],
                Cc_number = collection["Cc_number"],
                Cc_expiration = collection["Cc_expiration"],
                Cc_cvv = collection["Cc_cvv"],
                Valor = Convert.ToDecimal(collection["Valor"])
            };

            _db.Ventas.Add(nuevaVenta);
            _db.SaveChanges();

            //Llamar ultima orden grabada
            int UltimaIdVenta = _db.Ventas.Max(item => item.Id);

            //Grabar detalle de venta
            //Revisar venga detalle
            string ListProducts = collection["listadoProductos"];

            if (ListProducts != null)
            {
                dynamic ListaProductos = JsonConvert.DeserializeObject(ListProducts);

                foreach (var detalle in ListaProductos)
                {
                    VentaDetalle ventaDetalle = new VentaDetalle();

                    ventaDetalle.IdVenta = UltimaIdVenta;
                    ventaDetalle.IdProducto = Convert.ToInt32(detalle["idProducto"]);
                    ventaDetalle.Cantidad = Convert.ToInt32(detalle["cantProducto"]);
                    ventaDetalle.PrecioUnitario = Convert.ToDecimal(detalle["precio"]);
                    ventaDetalle.SubTotal = Convert.ToDecimal(detalle["subTotal"]);

                    _db.VentaDetalles.Add(ventaDetalle);
                }
            }

            _db.SaveChanges();
            TempData["Carrito"] = "Borrar Carrito";
            TempData["Mensaje"] = "Venta procesada correctamente!";
            return RedirectToAction("Index","Productos");
        }
    }
}
