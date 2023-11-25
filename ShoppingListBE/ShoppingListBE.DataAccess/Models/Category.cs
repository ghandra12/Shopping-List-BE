using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; }
        public string? Image { get; set; }
        public ICollection<Product> Products { get; } = new List<Product>();
        public Client? Client { get; set; } 
    }
}
