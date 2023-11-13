using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        List<Client> GetAdministrators();
    }

}
