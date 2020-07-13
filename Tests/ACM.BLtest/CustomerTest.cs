using System;
using System.Collections.Concurrent;
using System.Reflection;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLtest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Chris",
                LastName = "Floyd"
            };
            string expected = "Floyd, Chris";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {
                
                LastName = "Floyd"
            };
            string expected = "Floyd";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            Customer customer = new Customer
            {

                FirstName = "Chris"
            };
            string expected = "Chris";
            //Act
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Chris";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Jonny";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Jimmy";
            Customer.InstanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {

            //Arrange
            var customer = new Customer
            {
                LastName = "Floyd",
                Email = "Dude16@mail.com"
            };
            var expected = true;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailData()
        {
            //Arrange
            var customer = new Customer
            {
                LastName = "Floyd"
            };
            
            var expected = false;
            //Act
            var actual = customer.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestProductValidate()
        {
            //Arrange
            var producttest = new Product
            {
                Name = "Sprocket set",
                Description = "9 piece set",
                Price = 15.99m
            };
            var expected = true;

            //Act
            var actual = producttest.Validate();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OrderDateTest()
        {
            //Arrange
            var datetest = new Order
            {
                OrderDate = DateTime.UtcNow
            };
            var expected = DateTime.UtcNow;
            //Act
            var actual = datetest.OrderDate;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
