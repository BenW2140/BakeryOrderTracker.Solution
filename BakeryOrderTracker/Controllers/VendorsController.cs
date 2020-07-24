using Microsoft.AspNetCore.Mvc;
using BakeryOrderTracker.Models;
using System.Collections.Generic;

namespace BakeryOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> vendors = Vendor.GetAll();
      return View(vendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor specificVendor = Vendor.Find(id);
      List<Order> vendorOrders = specificVendor.Orders;
      model.Add("vendor", specificVendor);
      model.Add("orders", vendorOrders);
      return View(model);
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
    [HttpPost("vendors/delete")]
    public ActionResult Delete()
    {
      Vendor.ClearAll();
      return RedirectToAction("Index");
    }
  }
}