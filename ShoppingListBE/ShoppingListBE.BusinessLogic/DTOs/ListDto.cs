using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.DTOs
{
    public class ListDto
    {
        public int Id { get; set; }
        public string ClientId { get; set; } = null!;
    }
}
