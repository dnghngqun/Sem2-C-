using Pro3.model;
namespace Pro3.service
{
    public interface IProductService
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}