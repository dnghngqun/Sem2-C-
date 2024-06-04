using Pro3.service;
using Pro3.model;
namespace Pro3.controller
{
    public class ProductController
    {
        //call instance of model
        private IProductService productService;
        public ProductController(IProductService proService)
        {
            productService = proService;
        }

        public void AddProduct(Product product)
        {
            productService.AddProduct(product);
        }
    }
}