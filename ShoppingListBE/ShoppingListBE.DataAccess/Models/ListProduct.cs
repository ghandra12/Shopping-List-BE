using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class ListProduct
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ListId { get; set; }
        public int ProductId { get; set; }
        public List List { get; set; } = null!;
        public Product  Product { get; set; } = null!;

    }
}
