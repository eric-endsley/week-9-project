using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrders.Models;
using System;

namespace VendorOrders.Tests
{
    [TestClass]
    public class OrderTests /*: IDisposable*/
    {
        // public void Dispose()
        // {
        //     Order.ClearAll();
        // }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("", "", "", 1);
            Assert.AreEqual(typeof(int), newOrder.GetType());
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

        
    }
}