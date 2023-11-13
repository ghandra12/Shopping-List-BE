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
