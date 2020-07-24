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
      Vendor newVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsCorrectName_String()
    {
      string name = "name";
      Vendor newVendor = new Vendor(name);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsCorrectId_Int()
    {
      Vendor newVendor = new Vendor("name");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor vendor1 = new Vendor("name");
      Vendor vendor2 = new Vendor("please?");
      List<Vendor> newList = new List<Vendor> {vendor1, vendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}