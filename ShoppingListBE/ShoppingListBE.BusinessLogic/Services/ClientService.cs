using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
using ShoppingListBE.DataAccess.Models;

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

        public List<ClientDto> GetClientById(int id)
        {
            var client = unitOfWork.Clients.GetAll().Where(c => c.Id == id);
            return client.Select(c=>new ClientDto() { Id = c.Id,Name=c.FirstName + " " +c.LastName}).ToList();
        }
        public async Task AddClient(ClientDto client)
        {
            await unitOfWork.Clients.InsertAsync(new Client { FirstName = client.FirstName,LastName=client.LastName,Email=client.Email,Password=client.Password,PhoneNumber=client.PhoneNumber});
            unitOfWork.SaveChanges();
        }
    }
}
