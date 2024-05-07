using PetConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using PetConsultas.Data;



namespace PetConsultas.Controllers
{
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        
        }
        [HttpGet]
        public IActionResult NovoCad() 
        { 
            return View("");
        }
       
    }
}
        
