using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.DataAccess.Models
{
    public class List
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public bool isFinished { get; set; }
        public Client Client { get; set; } = null!;
        public List<ListProduct> ListsProducts { get; } = new();
    }
}

