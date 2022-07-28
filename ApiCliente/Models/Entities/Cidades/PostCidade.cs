using System.ComponentModel.DataAnnotations;

namespace testeentity.Models.Entities.Cidades
{
    public class PostCidade
    {
        [Required]
        public string Nome { get; set; }
        public string NomeEstado { get; set; }
    }
}
