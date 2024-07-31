namespace Games_Mvc.Models
{
    public class Cena
    {
        public int Id { get; set; }
        public string NomeCena { get; set; }
        public string Descrição { get; set; }

        public ICollection<Escolha>Escolha { get; set; }
    }
}
