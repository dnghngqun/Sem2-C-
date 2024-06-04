using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pro3.model;


namespace Pro3.service
{
    public class OrderService:IOrderService
    {

        private MySqlConnection conn;
        //contructor
        public OrderService(string connectionString)
        {
            conn = new MySqlConnection(connectionString);
        }

        public void AddOrder(Order order){

        }
        public List<Order> GetAllOrders(){
            return null;
        }
        public Order GetOrderById(int id){
            return null;
        }
    }
}