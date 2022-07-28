using System.ComponentModel.DataAnnotations;

namespace testeentity.Models
{
    public class Cidades
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeEstado { get; set; }
    }
}
