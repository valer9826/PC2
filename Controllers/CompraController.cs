using Microsoft.AspNetCore.Mvc;

namespace pc2.Controllers
{
    public class CompraController : Controller
    {
        public IActionResult Resumen()
        {
            return View();
        }
    }
}