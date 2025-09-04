using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ocelot.Article.Model;
using Ocelot.Article.Repo;

namespace Ocelot.Article.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Articles>> GetAll()
        {
            var articles = ArticleRepo.GetAll();
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public ActionResult<Articles> GetById(int id)
        {
            var article = ArticleRepo.GetById(id);
            if (article == null)
                return NotFound(new { Message = $"Article with id {id} not found" });
            return Ok(article);
        }

    }
}
