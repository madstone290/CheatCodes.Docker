namespace BookApi.Models
{
    public class Book
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public int Page { get; set; }

        public static Book Random()
        {
            return new Book()
            {
                Title = LoremNET.Lorem.Words(2, 6),
                Author = LoremNET.Lorem.Words(2, 3),
                Page = (int)LoremNET.Lorem.Number(100, 500),
            };
        }
    }
}
