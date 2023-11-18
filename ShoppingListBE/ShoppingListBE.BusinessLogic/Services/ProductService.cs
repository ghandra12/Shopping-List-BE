using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.Services
{
    public class ProductService : IProductService
    {

        public IUnitOfWork unitOfWork { get; set; }
        public ProductService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public List<ProductDto> GetProductsByCategory(int id)
        {
            var products = unitOfWork.Products.GetAll().Where(p=>p.CategoryId==id);
            return products.Select(p => new ProductDto() { Id = p.Id, Name = p.Name,Description=p.Description}).ToList();
        }
    }
}
