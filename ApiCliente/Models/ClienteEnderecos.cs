using System.ComponentModel.DataAnnotations;

namespace testeentity.Models
{
    public class ClienteEnderecos
    {
        [Key]
        public int Id { get; set; }
        public char TpEndereco { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public Cidades cidade { get; set; }

    }
}
