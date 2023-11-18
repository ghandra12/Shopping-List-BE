using Microsoft.EntityFrameworkCore;
using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShoppingListDBContext db;
        private IClientRepository? clientsRepository;
        private IProductRepository? productsRepository;
        private IListProductRepository? listsproductsRepository;
        private IListRepository? listRepository;
        private ICategoryRepository? categoriesRepository;
        public UnitOfWork(ShoppingListDBContext dbContext)
        {
            db = dbContext;
        }

        public IClientRepository Clients
        {
            get
            {
                if (this.clientsRepository == null)
                {
                    this.clientsRepository = new ClientRepository(db);
                }
                return this.clientsRepository;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (this.productsRepository == null)
                {
                    this.productsRepository = new ProductRepository(db);
                }
                return this.productsRepository;
            }
        }

        public IListProductRepository ListsProducts
        {
            get
            {
                if (this.listsproductsRepository == null)
                {
                    this.listsproductsRepository = new ListProductRepository(db);
                }
                return this.listsproductsRepository;
            }
        }

        public IListRepository Lists
        {
            get
            {
                if (this.listRepository == null)
                {
                    this.listRepository = new ListRepository(db);
                }
                return this.listRepository;
            }
        }

        public ICategoryRepository Categories        {
            get
            {
                if (this.categoriesRepository == null)
                {
                    this.categoriesRepository = new CategoryRepository(db);
                }
                return this.categoriesRepository;
            }
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
