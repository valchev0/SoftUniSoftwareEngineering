using System.Threading.Channels;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article article = new Article();

            string[] data = Console.ReadLine().Split(',');
            article.Title = data[0];
            article.Content = data[1];
            article.Author = data[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(":");
                switch (tokens[0])
                {
                    case "Rename":
                        article.Title = tokens[1];
                        break;
                    case "Edit":
                        article.Content = tokens[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = tokens[1];
                        break;
                }
            }
            Console.WriteLine($"{article.Title} -{article.Content}:{article.Author}");
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}

