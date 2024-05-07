using PetConsultas.Enums;
using System.ComponentModel.DataAnnotations;

namespace PetConsultas.Models
{
    public class CadPacienteModel
    {
        public int Id { get; set; }

        public string? NameTutor { get; set; }

        public int CpfTutor { get; set; }
        public string? login { get; set; }
        public string? email { get; set; }   
        public int senhaTutor { get; set;}
        public PerfilEnum usuarios { get; set; }
        public DateTime datacadastro { get; set; }
        public DateTime? dataarualizacao { get; set; }   
    }
}
