using PetConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using PetConsultas.Data;

namespace PetConsultas.Controllers
{
    public class ConsultasController : Controller
    {
        public IActionResult Index()
        {

            return View();

        }
        
  
         public IActionResult AgendarConsultas()
        {
            return View("AgendarConsultas");
        }

    }

   

}