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
    }
}