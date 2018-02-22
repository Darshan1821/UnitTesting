using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductManagement;
using System.Collections.Generic;

namespace ProductTest
{
    [TestClass]
    public class BuyProductTests
    {
        private ProductRepository _productRepository;
        private List<Product> _productList;

        [TestInitialize]
        public void TestInitialize()
        {
            _productList = new List<Product>();

            InitializeProduct();

            _productRepository = new ProductRepository(_productList);
        }

        [TestMethod]
        public void BuyProductTest()
        {
            var cabbagePrice = _productRepository.BuyProduct("cabbage",10);
            var zucchiniPrice = _productRepository.BuyProduct("zucchini",15);

            Assert.AreEqual(507.5, cabbagePrice + zucchiniPrice, 0.01);
        }

        private void InitializeProduct()
        {
            _productList.Add(new Product() { Name = "Lettuce", Price = 10.5, Quantity = 50, Type = "Leafy Green" });
            _productList.Add(new Product() { Name = "Cabbage", Price = 20, Quantity = 100, Type = "Cruciferous" });
            _productList.Add(new Product() { Name = "Pumpkin", Price = 30, Quantity = 30, Type = "Marrow" });
            _productList.Add(new Product() { Name = "Cauliflower", Price = 10, Quantity = 25, Type = "Cruciferous" });
            _productList.Add(new Product() { Name = "Zucchini", Price = 20.5, Quantity = 50, Type = "Marrow" });
            _productList.Add(new Product() { Name = "Yam", Price = 30, Quantity = 50, Type = "Root" });
            _productList.Add(new Product() { Name = "Spinach", Price = 10, Quantity = 100, Type = "Leafy Green" });
            _productList.Add(new Product() { Name = "Broccoli", Price = 20.2, Quantity = 75, Type = "Cruciferous" });
            _productList.Add(new Product() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy Green" });
            _productList.Add(new Product() { Name = "Silverbeet", Price = 10, Quantity = 50, Type = "Marrow" });
        }
    }
}
