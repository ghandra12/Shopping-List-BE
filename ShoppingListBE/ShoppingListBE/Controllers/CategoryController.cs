using Microsoft.AspNetCore.Mvc;
using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.BusinessLogic.Services;

namespace ShoppingListBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        public ICategoryService categoryService { get; set; }
        public CategoryController(ICategoryService _categoryService)
        {
            categoryService = _categoryService;
        }

        [HttpGet]
        public List<CategoryDto> Get()
        {
            return categoryService.GetGeneralCategories();
        }
    }
}
