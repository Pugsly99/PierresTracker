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

    }
}