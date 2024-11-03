namespace Articles2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(", ");
                Article article = new()
                {
                    Title = tokens[0],
                    Content = tokens[1],
                    Author = tokens[2]
                };
                articles.Add(article);
            }
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}

