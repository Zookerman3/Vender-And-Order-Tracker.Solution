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
            Order newOrder = new Order("order", "description", 3, "date");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetTitle_ReturnsTitle_String()
        {
            //Arrange
            string title = "Pastries";
            string description = "Pastries for bakery";
            float price = 3;
            string date = "date";

            //Act
            Order newOrder = new Order(title, description, price, date);
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual(title, result);
        }
        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            //Arrange
            string title = "Pastries";
            string description = "Pastries for bakery";
            float price = 3;
            string date = "date";
            Order newOrder = new Order(title, description, price, date);

            //Act
            string updatedTitle = "Bread";
            newOrder.Title = updatedTitle;
            string result = newOrder.Title;

            //Assert
            Assert.AreEqual(updatedTitle, result);
        }
    }
}
