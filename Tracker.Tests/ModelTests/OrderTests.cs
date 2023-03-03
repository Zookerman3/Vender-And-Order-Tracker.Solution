using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class OrderTests
    {

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("order");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            //Arrange
            string description = "Pastries";

            //Act
            Order newOrder = new Order(description);
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(description, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string description = "Pastries.";
            Order newOrder = new Order(description);

            //Act
            string updatedDescription = "Bread";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            //Assert
            Assert.AreEqual(updatedDescription, result);
        }
    }
}