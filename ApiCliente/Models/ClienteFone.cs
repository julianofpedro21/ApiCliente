using System.ComponentModel.DataAnnotations;

namespace testeentity.Models
{
    public class ClienteFone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Telefone { get; set; }

        public string Contato { get; set; }
    }
}
