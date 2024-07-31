namespace Games_Mvc.Models
{
    public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Status { get; set; }
        public ICollection<Relacionamento>Relacionamentos { get; set; }
    }
}

