namespace codefirt.Models
{
    public class Desenvolvedora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
