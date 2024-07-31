namespace Games_Mvc.Models
{
    public class Escolha
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public string Consequencia { get; set; }
        public int CenaId { get; set; }
        public Cena Cena { get; set; }
    }
}
