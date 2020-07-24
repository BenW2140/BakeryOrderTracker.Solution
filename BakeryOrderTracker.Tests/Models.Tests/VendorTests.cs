using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace BakeryOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    // Test methods go here
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "descriptive");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsCorrectName_String()
    {
      string name = "name";
      string description = "descriptive";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCorrectId_Int()
    {
      Vendor newVendor = new Vendor("name", "descriptive");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor vendor1 = new Vendor("name", "very");
      Vendor vendor2 = new Vendor("please?", "descriptive");
      List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsASpecificVendor_Vendor()
    {
      Vendor vendor1 = new Vendor("name", "very");
      Vendor vendor2 = new Vendor("please?", "descriptive");
      Vendor result = new Vendor("empty", "gone");
      Assert.AreEqual(vendor1, result);
    }
  }
}