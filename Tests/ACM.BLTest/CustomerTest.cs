using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            // var customer = new Customer();
            Customer customer = new Customer
            {
                FirstName = "Bildo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bildo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }


    [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange

            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";        

            //-- Act
            string actual = customer.FullName;
            

            //-- Assert
            Assert.AreEqual (expected, actual);
            
        }


        



    }
}
