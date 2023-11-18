using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Repository
{
 
    public class ListProductRepository : BaseRepository<ListProduct>, IRepository.IListProductRepository
    {
        public ListProductRepository(ShoppingListDBContext _db) : base(_db)
        {

        }
    }
}
