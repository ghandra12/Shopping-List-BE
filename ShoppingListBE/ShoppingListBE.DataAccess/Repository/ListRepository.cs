using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Repository
{
    public class ListRepository : BaseRepository<List>, IListRepository
    {
        public ListRepository(ShoppingListDBContext _db) : base(_db)
        {

        }
    }
}
