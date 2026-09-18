namespace codefirt.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int AnoLancamento { get; set; }
        public int DesenvolvedoraId { get; set; }
        public Desenvolvedora? Desenvolvedora { get; set; }
        public ICollection<Genero> Generos { get; set; } = new List<Genero>();
    }
}
