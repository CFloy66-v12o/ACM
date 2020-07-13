using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLtest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Assign
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                              new TimeSpan(7, 0, 0))
            };
            //Act
            var actual = orderRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.OrderId, actual.OrderId);
        }
    }
}
