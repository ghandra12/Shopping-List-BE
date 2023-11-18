using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
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
            var categories = unitOfWork.Categories.GetAll().Where(c=> c.ClientId==0);
            return categories.Select(c => new CategoryDto() { Id = c.Id, Name = c.Name, Description=c.Description,ClientId=c.ClientId}).ToList();
        }
    }
}
