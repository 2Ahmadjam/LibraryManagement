using KitapYonetim.Common.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.API.Services
{
    public interface IOrdersService
    {
        Task<IList<Order>> GetOrders();

        Task<Order> GetOrderById(int id);

        Task<Order> CreateOrder(Order order);

        Task UpdateOrder(Order order);

        Task DeleteOrder(int id);
    }
}
