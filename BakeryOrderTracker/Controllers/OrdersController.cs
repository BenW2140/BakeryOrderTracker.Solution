using Microsoft.AspNetCore.Mvc;
using BakeryOrderTracker.Models;
using System.Collections.Generic;

namespace BakeryOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order specificOrder = Order.Find(orderId);
      Vendor specificVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", specificOrder);
      model.Add("vendor", specificVendor);
      return View(model);
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}