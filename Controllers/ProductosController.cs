using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HPPParcial2.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using X.PagedList.Mvc.Core;
using X.PagedList;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;


namespace HPPParcial2.Controllers
{
    public class ProductosController : Controller
    {

        private readonly SantaMonicaDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductosController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, SantaMonicaDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index(string campobusqueda, int? pagina)
        {
            var productosDb = _context.Productos
            .Select(p => new ProductosDto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Marca = p.Marca,
                Detalle = p.Detalle,
                Costo = p.Costo,
                FotoRuta = (p.FotoRuta == null) ? "sinfoto.png" : p.FotoRuta
            })
            .ToList();
            if (!String.IsNullOrEmpty(campobusqueda))
            {
                productosDb = productosDb.Where(a => a.Marca.ToUpper().Contains(campobusqueda.ToUpper())
                  || a.Nombre.ToUpper().Contains(campobusqueda.ToUpper())
                ).ToList<ProductosDto>();
            }
            return View(Paginar(productosDb, pagina));
        }

        private IPagedList Paginar(List<ProductosDto> lista, int? pagina)
        {
            int tamanioPagina = 9;
            int numeroPagina = (pagina ?? 1);
            return lista.ToPagedList(numeroPagina, tamanioPagina);
        }


        [HttpPost]
        public IActionResult Agregar(Productos producto)
        {
            if (ModelState.IsValid)
            {
                if (producto.Foto != null)
                {
                    string carpetaFotos = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                    string nombreArchivo = producto.Foto.FileName;
                    string rutaCompleta = Path.Combine(carpetaFotos, nombreArchivo);
                    //subimos la imagen al servidor
                    producto.Foto.CopyTo(new FileStream(rutaCompleta, FileMode.Create));
                    //guardar la ruta de la imagen en la base de datos
                    producto.FotoRuta = nombreArchivo;
                }
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        public IActionResult Agregar()
        {
            if (_userManager.GetUserName(HttpContext.User) == "camaralea@gmail.com")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Eliminar(Productos producto)
        {
            _context.Productos.Remove(producto); // o tambieen removerange si le paso una lista, update modifica
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Comprar(Productos producto)
        {
            if (_userManager.GetUserName(HttpContext.User) != null)
            {
                var usuariosDb = _context.Usuarios
               .Select(p => new Usuarios()
               {
                   Id = p.Id,
                   Nombre = p.Nombre,
                   Contrasenia = p.Contrasenia,
                   ZonaId = p.ZonaId
               })
               .ToList();
                usuariosDb = usuariosDb.Where(a => a.Nombre.Contains(_userManager.GetUserName(HttpContext.User))).ToList<Usuarios>();
                Usuarios usuarioActual = usuariosDb.FirstOrDefault();
                Orden nuevaOrden = new Orden { ProduId = producto.Id, Cantidad = 1, UsuarioId = usuarioActual.Id, EstadoId = 5 };
                _context.Orden.Add(nuevaOrden);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        /*public IActionResult Borrar(int id)
        {
            var actor = _context.Actores.Where(x => x.Id == id).First();
            _context.Actores.FromSqlRaw("delete from actores where id={0}",id) otra forma de borrar
            _context.Actores.Remove(actor);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }*/


        [HttpPost]
        public IActionResult Editar(Productos producto)
        {
            if (ModelState.IsValid)
            {
                var prodAnte = _context.Productos.Where(p => p.Id == producto.Id).FirstOrDefault();
                if (prodAnte != null)
                {
                    if (producto.Foto != null)
                    {
                        string carpetaFotos = Path.Combine(_hostingEnvironment.WebRootPath, "img");
                        string nombreArchivo = producto.Foto.FileName;
                        string rutaCompleta = Path.Combine(carpetaFotos, nombreArchivo);
                        producto.Foto.CopyTo(new FileStream(rutaCompleta, FileMode.Create));
                        producto.FotoRuta = nombreArchivo;
                    }
                    _context.Productos.Remove(prodAnte);
                    _context.Productos.Add(producto);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(producto);
                }
            }
            return View(producto);
        }

        public IActionResult Editar(int id)
        {
            var prod = _context.Productos.Where(x => x.Id == id).FirstOrDefault();
            return View(prod);
        }

        public IActionResult Edicion()
        {
            if (_userManager.GetUserName(HttpContext.User) == "camaralea@gmail.com")//sumar viewbag y comparar con el dato para que quede inahbilitao
            {
                var productosDb = _context.Productos
                .Select(p => new ProductosDto()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Marca = p.Marca,
                    Detalle = p.Detalle,
                    Costo = p.Costo,
                    Ingreso = p.Ingreso,
                    TipoProductoNombre = p.TipoProducto.Descripcion,
                    FotoRuta = (p.FotoRuta == null) ? "sinfoto.png" : p.FotoRuta
                })
                .ToList();
                return View(productosDb);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult SubPagina(int categoria)
        {
            var productosDb = _context.Productos
            .Where(p => p.TipoProductoId == categoria)
            .Select(p => new ProductosDto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Marca = p.Marca,
                Detalle = p.Detalle,
                Costo = p.Costo,
                FotoRuta = (p.FotoRuta == null) ? "sinfoto.png" : p.FotoRuta
            })
            .ToList();


            return View(productosDb);
        }



        public IActionResult OrderPrecio()
        {
            var productosDb = _context.Productos
            .Select(p => new ProductosDto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Marca = p.Marca,
                Detalle = p.Detalle,
                Costo = p.Costo,
                FotoRuta = (p.FotoRuta == null) ? "sinfoto.png" : p.FotoRuta
            }).OrderBy(x => x.Costo)
            .ToList();
            return View(productosDb);
        }
        public IActionResult OrderABC()
        {
            var productosDb = _context.Productos
            .Select(p => new ProductosDto()
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Marca = p.Marca,
                Detalle = p.Detalle,
                Costo = p.Costo,
                FotoRuta = (p.FotoRuta == null) ? "sinfoto.png" : p.FotoRuta
            }).OrderBy(x => x.Nombre)
            .ToList();
            return View(productosDb);
        }

        public IActionResult Iniciar()
        {
            return View();
        }


        public IActionResult Carrito()
        {
            if (_userManager.GetUserName(HttpContext.User) != null)
            {
                var usuariosDb = _context.Usuarios
               .Select(p => new Usuarios()
               {
                   Id = p.Id,
                   Nombre = p.Nombre,
                   Contrasenia = p.Contrasenia,
                   ZonaId = p.ZonaId
               })
               .ToList();
                usuariosDb = usuariosDb.Where(a => a.Nombre.Contains(_userManager.GetUserName(HttpContext.User))).ToList<Usuarios>();
                Usuarios usuarioActual = usuariosDb.FirstOrDefault();

                var ordenesDB = _context.Orden.Include(a => a.Produ).Include(a => a.Usuario.Zona)
                .Where(a => a.UsuarioId.Equals(usuarioActual.Id))
                .Where(a => a.EstadoId == 5)
                .Select(p => new OrdenDto()
                {
                    Marca = p.Produ.Marca,
                    ProduNombre = p.Produ.Nombre,
                    ProduCosto = p.Produ.Costo,
                    Cantidad = p.Cantidad,
                    ZonaNombre = p.Usuario.Zona.Descripcion
                }).ToList<OrdenDto>();

                return View(ordenesDB);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Vaciar()
        {
            var usuariosDb = _context.Usuarios
           .Select(p => new Usuarios()
           {
               Id = p.Id,
               Nombre = p.Nombre,
               Contrasenia = p.Contrasenia,
               ZonaId = p.ZonaId
           })
           .ToList();
            usuariosDb = usuariosDb.Where(a => a.Nombre.Contains(_userManager.GetUserName(HttpContext.User))).ToList<Usuarios>();
            Usuarios usuarioActual = usuariosDb.FirstOrDefault();

            var ordenesDB = _context.Orden
            .Where(a => a.UsuarioId.Equals(usuarioActual.Id))
            .Where(a => a.EstadoId == 5).ToList<Orden>();

            _context.Orden.RemoveRange(ordenesDB);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Confirmar()
        {
            var usuariosDb = _context.Usuarios
           .Select(p => new Usuarios()
           {
               Id = p.Id,
               Nombre = p.Nombre,
               Contrasenia = p.Contrasenia,
               ZonaId = p.ZonaId
           })
           .ToList();
            usuariosDb = usuariosDb.Where(a => a.Nombre.Contains(_userManager.GetUserName(HttpContext.User))).ToList<Usuarios>();
            Usuarios usuarioActual = usuariosDb.FirstOrDefault();

            var ordenesDB = _context.Orden
            .Where(a => a.UsuarioId.Equals(usuarioActual.Id))
            .Where(a => a.EstadoId == 5).ToList<Orden>();

            foreach (Orden ordenNueva in ordenesDB)
            {
                ordenNueva.EstadoId = 4;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
