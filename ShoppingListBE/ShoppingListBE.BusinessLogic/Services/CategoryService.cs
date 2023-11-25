using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using ShoppingListBE.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.Services
{   public class CategoryService : ICategoryService
    {
        public IUnitOfWork unitOfWork { get; set; }
        public CategoryService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public List<CategoryDto> GetGeneralCategories()
        {
            var categories = unitOfWork.Categories.GetAll().Where(c=> c.ClientId == null);
            return categories.Select(c => new CategoryDto() { Id = c.Id, Name = c.Name, Description=c.Description,ClientId=c.ClientId,Image=c.Image}).ToList();
        }

        public async Task AddCategory(AddCategoryDto category)
        {
            string? base64Image = null;
            if (category.Image != null && category.Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    category.Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    base64Image = $"data:{category.Image.ContentType};base64," + Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
            }
            await unitOfWork.Categories.InsertAsync(new Category { Name = category.Name, Description = category.Description,Image=base64Image });
            unitOfWork.SaveChanges();
        }
    }
}
