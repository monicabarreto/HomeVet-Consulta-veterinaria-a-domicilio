using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetConsultas.Models;

namespace PetConsultas.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options )  : base (options)
        {
            
        }
        public DbSet<ConsultasPetModel> Consultas { get; set; }
        public DbSet<CadPacienteModel> CadPacienteModel { get; set; }
        public DbSet<CadProfissionalModel> CadProfissionalModel { get; set; }

    }   
}
