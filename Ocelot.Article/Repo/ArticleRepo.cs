using Ocelot.Article.Model;

namespace Ocelot.Article.Repo
{
    public static class ArticleRepo
    {
        public static List<Articles> Articles = new List<Articles>
        {
            new Articles { Id = 1, Title = "Article 1", Description = "This is Description 1", Author = "Author 1" },
            new Articles { Id = 2, Title = "Article 2", Description = "This is Description 2", Author = "Author 2" },
            new Articles { Id = 3, Title = "Article 3", Description = "This is Description 3", Author = "Author 3" }
        };

        // ✅ Get all products
        public static List<Articles> GetAll() => Articles;

        // ✅ Get product by ID
        public static Articles? GetById(int id) =>
            Articles.FirstOrDefault(p => p.Id == id);
    }
}
