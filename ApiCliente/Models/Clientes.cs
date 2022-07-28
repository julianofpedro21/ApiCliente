using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testeentity.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(120)]  
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public DateTime DtNascimento { get; set; }
        public DateTime DtCadastro { get; set; }
        public List<ClienteFone> Telefone { get; set; }
        public List<ClienteEnderecos> Endereco { get; set; }

        [NotMapped]
        public int Idade { get; set; }
    }
}
