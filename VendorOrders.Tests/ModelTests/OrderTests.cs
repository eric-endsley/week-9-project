using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrders.Models;
using System;

namespace VendorOrders.Tests
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
            Order newOrder = new Order("", "", "", 1);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void OrderConstructor_SetsPropertiesToArgumentsPassed_OrderProperties()
        {
            Order newOrder = new Order("test title", "test description", "test date", 1);
            Assert.AreEqual("test title", newOrder.Title);
            Assert.AreEqual("test description", newOrder.Description);
            Assert.AreEqual("test date", newOrder.Date);
            Assert.AreEqual(1, newOrder.Price);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_OrderList()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsListOfOrders_OrderList()
        {
            Order newOrder = new Order("", "", "", 1);
            Order newOrder2 = new Order("", "", "", 2);
            List<Order> newOrderList = new List<Order> { newOrder, newOrder2 };
            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newOrderList, result);
        }
        
        [TestMethod]
        public void ClearAll_ClearsListOfOrders_Void()
        {
            Order newOrder = new Order("", "", "", 3);
            List<Order> emptyList = new List<Order> { };

            Order.ClearAll();
            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(emptyList, result);
        }

    }
}