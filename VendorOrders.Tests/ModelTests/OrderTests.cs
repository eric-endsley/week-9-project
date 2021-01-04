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
            Order newOrder = new Order();
            Assert.AreEqual(typeof(Order), newItem.GetType())
        }
        
    }
}