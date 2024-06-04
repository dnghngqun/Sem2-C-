using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pro3.model;

namespace Pro3.service
{
    public interface IOrderService
    {
        void AddOrder(Order order);
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
    }
}