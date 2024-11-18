using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;

namespace ProductApp.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {   
        private readonly ILogger<ProductsController> _logger;
        //readonly = ctor veya tanımlandığı yerde belirlenir 
        //tanımlandığı yerde bir atama yapılmamış o zaman biz bir yerde newleyeceğiz.
        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }
        //biz bu products controller'i newlediğimiz zaman logger ifadesi bizim elimize gelecek 
        [HttpGet] 
        public IActionResult GetAllProducts()
        {
            var products = new List<Product>()
            {
                new Product { Id = 1, ProductName = "Computer"},
                new Product { Id = 2, ProductName = "Keyboard"},
                new Product { Id = 3, ProductName = "Mouse"}
            };
            _logger.LogInformation("GetAllProducts action has been called");
            return Ok(products); 

        }
        [HttpPost]
        public IActionResult GetAllProducts([FromBody] Product product)
        {
            _logger.LogWarning("product has been created");
            return StatusCode(201); //created 
        }


    }
}
