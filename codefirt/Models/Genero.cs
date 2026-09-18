namespace codefirt.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
