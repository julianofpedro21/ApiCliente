using System.ComponentModel.DataAnnotations;

namespace testeentity.Models.Entities.Clientes
{
    public class PostClientes
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public DateTime DtNascimento { get; set; }
        public List<ClienteFone> Telefone { get; set; }
        public List<ClienteEnderecos> Endereco { get; set; }
    }
}
