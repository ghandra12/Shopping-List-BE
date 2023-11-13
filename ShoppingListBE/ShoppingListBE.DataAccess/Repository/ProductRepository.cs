using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Repository
{

    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ShoppingListDBContext _db) : base(_db)
        {

        }

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            return GetAll().Where(p => p.CategoryId == id).ToList();
        }
    }
}
