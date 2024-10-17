using ProductService.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningActivity7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Product A", Price = 99.99m },
        new Product { Id = 2, Name = "Product B", Price = 49.99m },
        new Product { Id = 3, Name = "Product C", Price = 149.99m }
    };

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
