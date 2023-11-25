using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = "";
        public string? Description { get; set; } 
        public int Calories { get; set; } 
        public string? Image { get; set; } 
        public Client? Client { get; set; } 
        public Category Category { get; set; } = null!;
        public List<ListProduct> ListsProducts { get; } = new();
    }
}
