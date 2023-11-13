using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.IServices
{
    public interface IClientService
    {
        List<ClientDto> GetClients();
    }
}
