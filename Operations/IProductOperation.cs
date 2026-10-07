
using ProductModel.Models;

namespace ProductModel.Operations
{
    public interface IProductOperation
    {
        int Add(Product product);
        List<Product> GetProducts();

        Product UpdateProduct(Product product, int id);

        Product ProductById(int id);

        void DeleteProduct(int id);

        List<Product> ProductByCondition(int id);
    }
}