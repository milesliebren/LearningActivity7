using OrderService.Models;
using ProductService.Models;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>
    {
        new Order
        {
            OrderId = 1,
            OrderDate = DateTime.Now,
            CustomerName = "John Doe",
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Product A", Price = 99.99m },
                new Product { Id = 2, Name = "Product B", Price = 49.99m }
            }
        }
    };

        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return orders;
        }
    }

}
