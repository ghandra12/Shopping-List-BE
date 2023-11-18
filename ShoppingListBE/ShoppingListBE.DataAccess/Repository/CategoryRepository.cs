using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Repository
{
   public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShoppingListDBContext context) : base(context)
        {
        }

        public IQueryable<Category> GetCategoriesByClientId()
        {
            return GetAll().Where(c=> c.ClientId==1);
        }
    }
}
