using System.Collections.Generic;

namespace ProductManagement
{
    public interface IProductManager
    {
        int TotalNoOfProducts();
        List<Product> AddProduct(string name, double price, int quantity, string type);
        List<Product> FindProductByType(string productType);
        List<Product> DeleteProductByName(string productName);
        double BuyProduct(string productName, int productQuantity);
        List<Product> GetAllProducts();
    }
}
