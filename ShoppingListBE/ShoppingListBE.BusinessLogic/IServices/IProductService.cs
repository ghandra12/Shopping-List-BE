using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShoppingListBE.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.IServices
{
    public interface IProductService
    {
        List<ProductDto> GetProductsByCategory(int id);
    }
}
