using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ocelot.Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // ✅ GET all products
        [HttpGet]
        public ActionResult<IEnumerable<Model.Product>> GetAll()
        {
            var products = ProductRepo.GetAll();
            return Ok(products);
        }

        // ✅ GET product by ID
        [HttpGet("{id}")]
        public ActionResult<Model.Product> GetById(int id)
        {
            var product = ProductRepo.GetById(id);
            if (product == null)
                return NotFound(new { Message = $"Product with id {id} not found" });

            return Ok(product);
        }
    }
}
