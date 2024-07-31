using System.ComponentModel.DataAnnotations;

namespace Games_Mvc.Models
{
    public class Jogo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Plataforma { get; set; }

        [StringLength(100)]
        public string Genero { get; set; }

        [StringLength(255)]
        public string ImagemUrl { get; set; }
    }
}
