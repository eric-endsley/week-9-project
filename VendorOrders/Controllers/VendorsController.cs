using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor currentVendor = Vendor.Find(id);
            List<Order> vendorOrders = currentVendor.Orders;
            model.Add("vendor", currentVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDate, int orderPrice)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
            Vendor currentVendor = Vendor.Find(vendorId);
            currentVendor.AddOrder(newOrder);
            List<Order> vendorOrders = currentVendor.Orders;
            model.Add("vendor", currentVendor);
            model.Add("orders", vendorOrders);
            return View("Show", model);
        }
    }
}