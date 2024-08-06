namespace Games_Mvc.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Personagem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)] // Define um comprimento máximo para o campo Nome
        public string Nome { get; set; }

        [StringLength(500)] // Define um comprimento máximo para o campo Descricao
        public string Descricao { get; set; }

        [ForeignKey("Jogo")]
        public int JogoId { get; set; } // Chave estrangeira para o Jogo

        public Jogo Jogo { get; set; } // Navegação para o Jogo

        public string ImagemUrl { get; set; } // Adicione esta propriedade
        
    }
}
