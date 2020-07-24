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
  }
}