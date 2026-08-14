using Microsoft.AspNetCore.Mvc;
using ProductServiceDeployment.Models;
using ProductServiceDeployment.Operations;

namespace ProductServiceDeployment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductOperation productOperation;

        public ProductController(IProductOperation productOperation)
        {
            this.productOperation = productOperation;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = productOperation.GetAllProducts();

            return Ok(products);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            var result = productOperation.CreateProduct(product);

            return Ok(result);
        }
    }
}