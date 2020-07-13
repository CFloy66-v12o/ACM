using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonUnitTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Assign
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesntAddAdditionalSpace()
        {
            //Assign
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";
            

            //Act
            var actual = source.InsertSpaces();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
