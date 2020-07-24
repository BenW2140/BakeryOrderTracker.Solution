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
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", specificOrder);
      return View(model);
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string name, string description, float price, string date)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor specificVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(name, description, price, date);
      specificVendor.AddOrder(newOrder);
      List<Order> vendorOrders = specificVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", specificVendor);
      return View("Show", model);
    }
  }
}