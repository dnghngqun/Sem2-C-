using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pro3.model;
using MySql.Data.MySqlClient;
namespace Pro3.service
{
    public class CustomerService : ICustomerService
    {
        private MySqlConnection conn;

        public CustomerService(string connectionString)
        {
            conn = new MySqlConnection(connectionString);
        }
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> customers()
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}