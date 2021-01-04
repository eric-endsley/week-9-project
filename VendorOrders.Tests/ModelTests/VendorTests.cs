using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrders.Models;
using System;

namespace VendorOrder.Tests
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
            Vendor newVendor = new Vendor("", "");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void VendorConstructor_SetsPropertiesToArgumentsPassed_VendorProperties()
        {
            Vendor newVendor = new Vendor("testName", "testDescription");
            Assert.AreEqual("testName", newVendor.Name) ;
            Assert.AreEqual("testDescription", newVendor.Description);
        } 
        [TestMethod]
        public void GetId_ConstructorAssignsGettableID_VendorId()
        {
            Vendor newVendor = new Vendor("", "");
            int result = newVendor.Id;

            Assert.AreEqual(1, result);
        }
    }
}