
using ProductModel.Models;
using ProductModel.Operations;
namespace ProductModel.Service
{
    public class ProductOperation : IProductOperation
    {
        List<Product> products = new List<Product>();
        int IProductOperation.Add(Product product)
        {
            products.Add(product);
            return 1;
        }

        void IProductOperation.DeleteProduct(int id)
        {
            Product product = products.Find(a=>a.PId == id);
            products.Remove(product);
            Console.WriteLine("Product Deleted Successfully");

        }

        List<Product> IProductOperation.GetProducts()
        {
            if(products.Count() == 0) return null;
            return products;
        }

        List<Product> IProductOperation.ProductByCondition(int condition)
        {
            List<Product> SearchedProduct = products.Where(a=>a.PPrice<condition).ToList();
            if(SearchedProduct.Count == 0) return null;
            return SearchedProduct;
        }

        Product IProductOperation.ProductById(int id)
        {
            Product product= products.Find(a=>a.PId == id);
            if(product == null)
            {
                return null;
            }
            else
            {
                return product;
            }
        }

        Product IProductOperation.UpdateProduct(Product product, int id)
        {
            Product existing = products.Find(a=>a.PId == id);
            existing.PPrice = product.PPrice;
            return existing;
        }
    }
}