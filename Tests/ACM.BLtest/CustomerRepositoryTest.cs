using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLtest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerrepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "candude@me.com",
                FirstName = "Chris",
                LastName = "Floyd"

            };



            //Act
            var actual = customerrepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustId, actual.CustId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                Email = "candude@me.com",
                FirstName = "Chris",
                LastName = "Floyd",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "1234 Main st",
                        StreetLine2 = "apt 2",
                        City = "Some City",
                        State = "Some State",
                        PostalCode = "12345",
                        Country = "Europe"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "4321 My st",
                        StreetLine2 = "apt 4",
                        City = "Some other city",
                        State = "Some other state",
                        PostalCode = "54321",
                        Country = "Non-Europe"
                    }
                }
                
            };
            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            //iterate through the list
            
            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }
        }
    }
}
