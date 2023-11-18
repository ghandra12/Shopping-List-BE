using ShoppingListBE.BusinessLogic.DTOs;
using ShoppingListBE.BusinessLogic.IServices;
using ShoppingListBE.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListBE.BusinessLogic.Services
{
    public class ListService: IListService
    {

        public IUnitOfWork unitOfWork { get; set; }
        public ListService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public List<ListDto> GetLists(int id)
        {
            var lists = unitOfWork.Lists.GetAll().Where(l=>l.ClientId==id);
            return lists.Select(l => new ListDto() { Id = l.Id }).ToList();
        }
    }
}
