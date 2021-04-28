using Microsoft.AspNetCore.Mvc;

namespace pc2.Controllers
{
    public class CatalogoController : Controller
    {
        public IActionResult Productos()
        {
            return View();
        }

        public IActionResult Catalogo()
        {
            return View();
        }

        public IActionResult Servicios()
        {
            return View();
        }
    }
}