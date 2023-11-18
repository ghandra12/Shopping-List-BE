using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.IRepository
{

    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IProductRepository Products { get; }
        IListRepository Lists { get; }
        IListProductRepository ListsProducts { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();
    }

}
