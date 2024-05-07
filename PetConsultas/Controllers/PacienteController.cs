using Microsoft.AspNetCore.Mvc;

namespace PetConsultas.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
