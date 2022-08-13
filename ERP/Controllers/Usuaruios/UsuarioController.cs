using Microsoft.AspNetCore.Mvc;

namespace ERP.Controllers.Usuaruios
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
