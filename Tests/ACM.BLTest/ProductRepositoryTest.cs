using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;
namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        //--Arrange
        public void RetrieveValidTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(1)
            {
                CurrentPrice = 400.32M,
                ProductName = "Rich dad poor dad book",
                ProductDescription = "Paperback Book hard cover 416 gsm"
            };
            //--Act
            var actual = productRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            //Assert.AreEqual(expected.ProductName, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
        }
    }
}
