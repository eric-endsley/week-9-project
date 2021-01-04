using Microsoft.AspNetCore.Mvc;

namespace VendorOrders.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return view(allVendors);
        }
    }
}