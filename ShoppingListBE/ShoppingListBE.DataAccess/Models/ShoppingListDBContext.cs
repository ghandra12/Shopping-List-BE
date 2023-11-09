using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class ShoppingListDBContext : DbContext
    {
        public ShoppingListDBContext(DbContextOptions<ShoppingListDBContext> options)
            : base(options)
        { }

        public DbSet<Client> Clients => Set<Client>();
    }

}
