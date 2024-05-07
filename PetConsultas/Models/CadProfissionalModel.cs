namespace PetConsultas.Models
{
    public class CadProfissionalModel
    {
        public int Id { get; set; }
        public string NomeProfissional { get; set; }
        public string especialidadeProfissional { get; set; }
        public string emailProfissional { get; set; }
        public string cpfProfissional { get; set; }
        public string crmvlProfissional { get; set; }
        public string senha { get; set; }
        public DateTime datacadastro { get; set; }
        public DateTime? dataarualizacao { get; set; }

    }
}
