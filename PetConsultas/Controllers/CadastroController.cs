using PetConsultas.Models;
using Microsoft.AspNetCore.Mvc;
using PetConsultas.Data;

namespace PetConsultas.Controllers
{
    public class CadastroController : Controller
    {
        readonly private ApplicationDbContext _db;
        public CadastroController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadPaciente()
        {
            return View("CadastrarPaciente");
        }

        [HttpGet]
        public IActionResult CadProfissional()
        {
            return View("CadastrarProfissional");
        }

        [HttpPost]
        public IActionResult CadPaciente(CadPacienteModel cadPac)
        {
            if (ModelState.IsValid)
            {
                _db.Add(cadPac);
                _db.SaveChanges();
            }

           return RedirectToAction("Index", "Paciente");
        }

        [HttpPost]
        public IActionResult CadProfissional(CadProfissionalModel cadProf)
        {
            if (ModelState.IsValid)
            {
                _db.Add(cadProf);
                _db.SaveChanges();
            }
            return RedirectToAction("Index", "Profissional");
        }


    }
}