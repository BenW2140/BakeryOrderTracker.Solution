using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    // Test methods go here
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
  }
}