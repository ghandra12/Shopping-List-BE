using Microsoft.AspNetCore.Mvc;
using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.Models;

namespace ShoppingListBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController: ControllerBase
    {
        public IClientService clientService { get; set; }
        public ClientController(IClientService _clientService)
        {
            clientService = _clientService;
        }

        [HttpGet(Name = "GetClients")]
        public List<ClientDto> Get()
        {
            return clientService.GetClients();
        }
    }
}
