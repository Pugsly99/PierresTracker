using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresTracker.Models;
using System.Collections.Generic;
using System;

namespace PierresTracker.Tests
{
    [TestClass]
    public class VendorTest : IDisposable
    {

      public void Dispose()
      {
        Vendor.ClearAll();
      }

      [TestMethod]
      public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
      {
        Vendor newVendor = new Vendor("Test Vendor");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        string result = newVendor.Name;
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void GetId_ReturnVendorId_int()
      {
        string name = "Test Vendor";
        Vendor newVendor = new Vendor(name);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetAll_ReturnAllVendorObjects_VendorList()
      {
        string name = "Test Vendor1";
        string name2 = "Test Vendor2";
        Vendor newVendor1 = new Vendor(name);
        Vendor newVendor2 = new Vendor(name2);
        List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

        List<Vendor> result = Vendor.GetAll();

        CollectionAssert.AreEqual(newList, result);
      }
      
      [TestMethod]
      public void Find_ReturnCorrectVendor_Vendor()
      {
        string name = "Test Vendor1";
        string name2 = "Test Vendor2";
        Vendor newVendor1 = new Vendor(name);
        Vendor newVendor2 = new Vendor(name2);
        Vendor vendor = Vendor.Find(2);

        Assert.AreEqual(newVendor2, vendor);
      }
    }

    
}