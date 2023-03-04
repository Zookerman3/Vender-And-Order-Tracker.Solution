using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {

        public void Dispose()
        {
            Order.ClearAll();
        }
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
        public void SetTitle_SetTitle_String()
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
        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            // Arrange
            List<Order> newList = new List<Order> { };

            // Act
            List<Order> result = Order.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            //Arrange
            string title1 = "Pastries";
            string description1 = "Pastries for bakery";
            float price1 = 3;
            string date1 = "date";

            string title2 = "Bread";
            string description2 = "Bread for bakery";
            float price2 = 4;
            string date2 = "time";

            Order newOrder1 = new Order(title1, description1, price1, date1);
            Order newOrder2 = new Order(title2, description2, price2, date2);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };

            //Act
            List<Order> result = Order.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
