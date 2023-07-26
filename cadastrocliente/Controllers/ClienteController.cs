using Microsoft.AspNetCore.Mvc;

namespace cadastrocliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
