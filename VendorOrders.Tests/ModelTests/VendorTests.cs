using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrders.Models;
using System;

namespace VendorOrder.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("", "");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void VendorConstructor_SetsPropertiesToArgumentsPassed_VendorProperties()
        {
            Vendor newVendor = new Vendor("testName", "testDescription");
            Assert.AreEqual(newVendor.Name, "testName");
            Assert.AreEqual(newVendor.Description, "testDescription");
        } 
    }
}