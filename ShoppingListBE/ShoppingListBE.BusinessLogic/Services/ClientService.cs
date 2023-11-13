using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;

namespace ShoppingListBE.BusinessLogic.Services
{
    public class ClientService: IClientService
    {
        public IUnitOfWork unitOfWork { get; set; }
        public ClientService(IUnitOfWork _unitOfWork) {
            unitOfWork = _unitOfWork;
        }

        public List<ClientDto> GetClients()
        {
            var clients = unitOfWork.Clients.GetAll();
            return clients.Select(c => new ClientDto() { Id = c.Id, Name = c.FirstName + " " +c.LastName }).ToList();
        }
    }
}
