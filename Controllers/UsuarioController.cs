using Microsoft.AspNetCore.Mvc;

namespace pc2.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Registro()
        {
            return View();
        }
        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult Actualizar()
        {
            return View();
        }
    }
}