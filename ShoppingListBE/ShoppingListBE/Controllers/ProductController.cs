using Microsoft.AspNetCore.Mvc;
using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;

namespace ShoppingListBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        public IProductService productService { get; set; }
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        [Route("{categoryId}")]
        public List<ProductDto> Get([FromRoute] int categoryId)
        {
            
            return productService.GetProductsByCategory(categoryId);
        }

        [HttpPost]
        public async Task Insert([FromForm] AddProductDto product)
        {
        
            await productService.AddProduct(product);
        }
    }
}
