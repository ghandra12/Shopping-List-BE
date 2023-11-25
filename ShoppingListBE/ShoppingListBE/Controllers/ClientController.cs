using Microsoft.AspNetCore.Mvc;
using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.BusinessLogic.Services;
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

        [HttpGet]
        public List<ClientDto> Get()
        {
            return clientService.GetClients();
        }


        [HttpPost]
        public async Task Insert([FromBody] ClientDto client)
        {
            await clientService.AddClient(client);
        }
    }
}
