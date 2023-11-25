using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
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
            return products.Select(p => new ProductDto() { Id = p.Id, Name = p.Name,Description=p.Description,Image=p.Image}).ToList();
        }

        public async Task AddProduct(AddProductDto product)
        {
            string? base64Image = null;
            if (product.Image != null && product.Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    product.Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    base64Image = $"data:{product.Image.ContentType};base64," + Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                }
            }
            await unitOfWork.Products.InsertAsync(new Product { Name = product.Name, Description = product.Description, CategoryId = product.CategoryId, Image = base64Image });
            unitOfWork.SaveChanges();
        }
    }
}
