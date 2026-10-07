
using ProductModel.Models;
using ProductModel.Operations;
using ProductModel.Service;
namespace ProductModel.UI
{
    public class Ui
    {
        public static void Main()
        {
            IProductOperation operation = new ProductOperation();

            Product product1 = new Product();
            product1.PId = 101;
            product1.PName = "Laptop";
            product1.PPrice = 25000;
            operation.Add(product1);

            Product product2 = new Product();
            product2.PId = 102;
            product2.PName = "Desktop";
            product2.PPrice = 62000;
            operation.Add(product2);

            Product product3 = new Product();
            product3.PId = 103;
            product3.PName = "Mobile";
            product3.PPrice = 12500;
            operation.Add(product3);
            // Getting All the products
            List<Product> products = operation.GetProducts();
            if (products == null)
            {
                Console.WriteLine("Record Not found!!!");
            }
            else
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product.PId + " " + product.PName + " " + product.PPrice);
                }
            }
            Console.WriteLine();
            //updating product
            Product update = new Product();
            update.PPrice = 20000;
            operation.UpdateProduct(update, 103);
            //searching updated product throud its id
            Product updated = operation.ProductById(103);
            Console.WriteLine("Searched product are: \n" + updated.PName + " " + updated.PPrice +"\n");
            //product by condition
            List<Product> filterProducts = operation.ProductByCondition(50000);
            if(filterProducts ==  null) Console.WriteLine("No Matching Product Found!!!");
            else
            {
                Console.WriteLine("Filered Proucts are: \n");
                foreach(Product product in filterProducts)
                {
                    Console.WriteLine(product.PId + " " + product.PName + " " + product.PPrice);
                }
            }
            Console.WriteLine();
            // deleting product
            operation.DeleteProduct(102);
            Console.WriteLine("Showing all the products: \n");
            if (products == null)
            {
                Console.WriteLine("Record Not found!!!");
            }
            else
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product.PId + " " + product.PName + " " + product.PPrice);
                }
            }
        }
    }
}