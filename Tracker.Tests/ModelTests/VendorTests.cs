using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test vendor", "test");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            //Arrange
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);

            //Act
            string result = newVendor.Name;

            //Assert
            Assert.AreEqual(name, result);
        }


        [TestMethod]
        public void GetId_ReturnsVendorId_Int()
        {
            //Arrange
            string name = "Test Vendor";
            string description = "Test Description";
            Vendor newVendor = new Vendor(name, description);

            //Act
            int result = newVendor.Id;

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            //Arrange
            string name01 = "Bakery";
            string name02 = "Cafe";
            string description1 = "5thStreet";
            string description2 = "6thStreet";
            Vendor newVendor1 = new Vendor(name01, description1);
            Vendor newVendor2 = new Vendor(name02, description2);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

            //Act
            List<Vendor> result = Vendor.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            //Arrange
            string name01 = "Bakery";
            string name02 = "Cafe";
            string description1 = "5thStreet";
            string description2 = "6thStreet";
            Vendor newVendor1 = new Vendor(name01, description1);
            Vendor newVendor2 = new Vendor(name02, description2);

            //Act
            Vendor result = Vendor.Find(2);

            //Assert
            Assert.AreEqual(newVendor2, result);
        }
        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            //Arrange
            string title1 = "Pastries";
            string description1 = "Pastries for bakery";
            float price1 = 3;
            string date1 = "date";
            Order newOrder = new Order(title1, description1, price1, date1);
            List<Order> newList = new List<Order> { newOrder };
            string name = "Bakery";
            string description = "Bakery needs pastries";
            Vendor newVendor = new Vendor(name, description);
            newVendor.AddOrder(newOrder);

            //Act
            List<Order> result = newVendor.Orders;

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}