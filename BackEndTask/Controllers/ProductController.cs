using BackEndTask.Models;
using BackEndTask.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo productRepo;

        public ProductController(IProductRepo productRepo)
        {
            this.productRepo = productRepo;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products=productRepo.GetProducts();
            return Ok(products);
        }
        [HttpPost]
        public IActionResult CrateProduct(Product product) 
        { 
            productRepo.CreateProduct(product);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            productRepo.DeleteProduct(id);
            return Ok();
        }

    }
}
