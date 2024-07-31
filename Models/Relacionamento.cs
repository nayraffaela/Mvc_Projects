namespace Games_Mvc.Models
{
    public class Relacionamento
    {
        public int Id { get; set; }
        public int PersonagemId { get; set; }
        public Personagem  Personagem { get; set; }
        public string NomePersonagemRelacionado { get; set; }
        public int ValorRelacionamento { get; set; }
          
    }
}
