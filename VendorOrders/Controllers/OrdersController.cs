using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrders.Models;

namespace VendorOrders.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Order currentOrder = Order.Find(orderId);
            Vendor currentVendor = Vendor.Find(vendorId);
            model.Add("vendor", currentVendor);
            model.Add("order", currentOrder);
            return View(model);
        }

    }
}