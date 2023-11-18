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
        public List<ProductDto> Get(int categoryId)
        {
            
            return productService.GetProductsByCategory(categoryId);
        }
    }
}
