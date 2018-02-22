using System;
using System.Collections.Generic;

namespace ProductManagement
{
    public class ProductRepository : IProductManager
    {
        public ProductRepository(List<Product> productList)
        {
            this.productList = productList;
        }

        public List<Product> AddProduct(string name, double price, int quantity, string type)
        {
            productList.Add(new Product() { Name=name, Price=price, Quantity=quantity, Type=type});
            return productList;
        }

        public double BuyProduct(string productName, int productQuantity)
        {
            var product = productList.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if(productQuantity > product.Quantity)
            {
                throw new Exception("Product quantity is more than the available quantity in the repository.");
            }
            else
            {
                return (product.Price * productQuantity);
            }
        }

        public List<Product> DeleteProductByName(string productName)
        {
            productList.RemoveAll(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
            return productList;
        }

        public List<Product> FindProductByType(string productType)
        {
            return productList.FindAll(p => p.Type.Equals(productType, StringComparison.OrdinalIgnoreCase));
        }

        public int TotalNoOfProducts()
        {
            return productList.Count;
        }

        public List<Product> GetAllProducts()
        {
            return productList;
        }

        private List<Product> productList = null;
    }
}
