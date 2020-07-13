using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLtest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Assign
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                Name = "Buzzsaw",
                Description = "12\" Buzzsaw",
                Price = 49.99m
            };
            

            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.ProductId, actual.ProductId);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                Name = "go go gadget arms",
                Description = "extendable gadget arms",
                Price = 100m,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }


        [TestMethod]
        public void SaveTestMissingProperty()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                Name = "go go gadget arms",
                Description = "extendable gadget arms",
                Price = null,
                HasChanges = true
            };

            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }
    }
}
