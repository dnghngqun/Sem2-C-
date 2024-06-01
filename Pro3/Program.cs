using System;
using MySql.Data.MySqlClient;

namespace Pro3
{
    class Program
    {
        static string connectionString = "Server=localhost;Database=prodb;User Id=root;Password=;";
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Product Management");
                Console.WriteLine("1. Add product"); 
                Console.WriteLine("2. Display all product");
                Console.WriteLine("3. Update product");
                Console.WriteLine("4. Delete product");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        DisplayAllProduct();
                        break;
                    case "3":
                        UpdateProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine(choice + " is not a valid choice");
                        break;
                }
            }
        }


        static void AddProduct()
        {
            Product product = new Product();
            Console.Write("Enter product name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter product price: ");
            product.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter product description: ");
            product.Description = Console.ReadLine();

            using(MySqlConnection conn = new MySqlConnection(connectionString)){
                conn.Open();
                String Query = "INSERT INTO Products (name, price, Description) VALUES (@Name, @Price, @Description)";
                using (MySqlCommand cmd = new MySqlCommand(Query, conn)){
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Product added successfully");

                }
                 
            }
        }

        static void UpdateProduct()
        {
            Product product = new Product();
            Console.Write("Enter product id to update: ");
            product.Id = int.Parse(Console.ReadLine());
            Console.Write("Enter product name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter product price: ");
            product.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter product description: ");
            product.Description = Console.ReadLine();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string Query = "UPDATE Products SET name = '@Name', price = @Price, Description = '@Description' WHERE id = @Id";
                using(MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", product.Id);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Product updated successfully"); 
                }
;
            }
        }

        static void DeleteProduct(){
            Console.Write("Enter product id to delete: ");
            int Id = int.Parse(Console.ReadLine());
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string Query = "DELETE Products WHERE id = @Id";
                using(MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Product removed succcessfully!");
                }
            }


        }

        static void DisplayAllProduct()
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string Query = "SELECT * FROM Products";
                using(MySqlCommand cmd = new MySqlCommand(Query, conn))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine($"Name: {reader["name"]}\nPrice: {reader["price"]}\nDescription: {reader["description"]}");
                        }
                    }
                }

            }
        }
    }

    class Product
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public decimal Price{ get; set; }
        public string Description{ get; set; }
    }
}
