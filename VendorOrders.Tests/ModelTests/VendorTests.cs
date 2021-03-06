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

        [TestMethod]
        public void GetAll_ReturnsEmptyList_VendorList()
        {
            List<Vendor> result = Vendor.GetAll();
            List<Vendor> emptyList = new List<Vendor> { };

            CollectionAssert.AreEqual(emptyList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsListOfAllVendors_VendorList()
        {
            Vendor newVendor1 = new Vendor("test", "test");
            Vendor newVendor2 = new Vendor("test2", "test2");
            List<Vendor> testList = new List<Vendor> { newVendor1, newVendor2 };

            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(testList, result);
        }
        
        [TestMethod]
        public void Find_FindsCorrectVendor_Vendor()
        {
            Vendor newVendor1 = new Vendor("test", "test");
            Vendor newVendor2 = new Vendor("test2", "test2");

            Vendor result = Vendor.Find(2);

            Assert.AreEqual(newVendor2, result);
        }

        [TestMethod]
        public void AddOrder_AddsOrderToOrdersListProperty_Order()
        {
            Vendor newVendor = new Vendor("test", "test");
            Order newOrder = new Order ("test", "test", "test", 1);
            newVendor.AddOrder(newOrder);

            Order result = newVendor.Orders[0];

            Assert.AreEqual(newOrder, result);
        }
    }
}