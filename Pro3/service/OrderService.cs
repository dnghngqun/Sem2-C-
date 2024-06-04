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
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            //create new giao dich
            MySqlTransaction transaction = conn.BeginTransaction();
            //thuc hien code them don hang moi
            //...
            cmd.CommandText = "INSERT INTO orders(customer_id, order_date) values(@CustomerId, @OrderDate)";
            cmd.Parameters.AddWithValue("@CustomerId",order.CustomerId);
            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            cmd.ExecuteNonQuery();
            int OrderId = (int)cmd.LastInsertedId;// lay ra id moi nhat vua duoc add o tren
            foreach(var detail in order.OrderDetails)
            {
                cmd.CommandText = "INSERT INTO order_detals(orderId,productId,quantity) VALUES(@OrderId, @ProductID, @Quantity)";
                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                cmd.Parameters.AddWithValue("@ProductId", detail.ProductId);
                cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                cmd.ExecuteNonQuery();
            
            }
            //ket thuc giao dich
            transaction.Commit();
        }
        public List<Order> GetAllOrders(){
            return null;
        }
        public Order GetOrderById(int id){
            return null;
        }
    }
}