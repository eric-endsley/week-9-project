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
            Vendor.ClearAll();
        }

        [TestMethod]
        OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("", "", "", "");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        OrderConstructor_SetsPropertiesToArgumentsPassed_OrderProperties()
        {
            Order newOrder = new Order("test title", "test description", "test price", "test date");
            Assert.AreEqual("test title", newOrder.Title);
            Assert.AreEqual("test description", newOrder.Description)
            Assert.AreEqual("test price", newOrder.Price)
            Assert.AreEqual("test date", newOrder.Date)
        }
        
    }
}