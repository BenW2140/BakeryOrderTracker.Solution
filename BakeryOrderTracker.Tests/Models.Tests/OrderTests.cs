using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void TestOrder_CreateAnOrder_Order()
    {
      Order newOrder = new Order("name", "descriptive", 10, "1/1/2020");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetProperties_ReturnsCorrectValues_Order()
    {
      string name = "name";
      string description = "descriptive";
      int price = 5;
      string date = "7/24/2020";
      Order result = new Order(name, description, price, date);
      Assert.AreEqual(name, result.Name);
      Assert.AreEqual(description, result.Description);
      Assert.AreEqual(price, result.Price);
      Assert.AreEqual(date, result.Date);
      Assert.AreEqual(1, result.Id);
    }
  }
}