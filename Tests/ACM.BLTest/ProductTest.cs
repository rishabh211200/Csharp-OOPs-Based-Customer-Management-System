using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerManagementSystem.BL;

namespace CMS.BLTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateBothEntries()
        {
            //We are going to follow the method of Arrange Act and Assert
            //--Arrange
            Product product = new Product()
            {
                ProductName = "Dsa Made Easy Book",
                CurrentPrice = 500
            };
            var expected = true;
            
            //act
            var actual = product.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateNameOnly()
        {
            //We are going to follow the method of Arrange Act and Assert
            //--Arrange
            Product product = new Product()
            {
                ProductName = "Dsa Made Easy Book"
            };
            var expected = false;

            //act
            var actual = product.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidatePriceOnly()
        {
            //We are going to follow the method of Arrange Act and Assert
            //--Arrange
            Product product = new Product()
            {
                CurrentPrice = 500
            };
            var expected = false;

            //act
            var actual = product.Validate();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
