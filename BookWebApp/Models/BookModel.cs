namespace BookWebApp.Models
{
    public class BookModel
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Page { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Author} {Page}";
        }
    }
}
