using ShoppingListBE.DataAccess.Models;
using ShoppingListBE.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess
{

    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(ShoppingListDBContext _db) : base(_db)
        {

        }

        public List<Client> GetAdministrators()
        {
            return GetAll().Where(c => c.IsAdmin).ToList();
        }
    }
}

