using Microsoft.AspNetCore.Mvc;

namespace VendorOrders.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        Vendor vendor = Vendor.Find(vendorId);
        return View(vendor)
    }
}