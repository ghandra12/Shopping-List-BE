using Microsoft.AspNetCore.Mvc;
using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;

namespace ShoppingListBE.Controllers
{
 
        [ApiController]
        [Route("[controller]")]
        public class ListController : ControllerBase
        {
            public IListService listService { get; set; }
            public ListController(IListService _listService)
            {
            listService = _listService;
            }

            [HttpGet]
            [Route("{clientId}")]
            public List<ListDto> Get(int clientId)
            {
                return listService.GetLists(clientId);
            }
        }
    
}
