
using MySql.Data.MySqlClient;
using Pro3.model;
namespace Pro3.service
{
    public class ProductService : IProductService
    {
        private MySqlConnection conn;

        public ProductService(string connectionString)
        {
            conn = new MySqlConnection(connectionString);
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Products (name, price, Description) VALUES (@Name, @Price, @Description)";
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@Description", product.Description);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Product added successfully");
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products= new List<Product>();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Products";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Product product = new Product();
                product.Name = reader.GetString("name");
                product.Price = reader.GetDecimal("price");
                product.Description = reader.GetString("description");
                products.Add(product);
            }
            return products;
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}