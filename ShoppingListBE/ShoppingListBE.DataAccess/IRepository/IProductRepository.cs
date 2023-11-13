using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.IRepository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategory(int id);
    }
}
