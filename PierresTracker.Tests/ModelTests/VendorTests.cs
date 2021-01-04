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
        Vendor newVendor = new Vendor("Test Vendor", "test vendor description");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      }

      [TestMethod]
      public void GetName_ReturnsName_String()
      {
        string name = "Test Vendor";
        string description = "test vendor description";
        Vendor newVendor = new Vendor(name, description);
        string result = newVendor.Name;
        Assert.AreEqual(name, result);
      }

      [TestMethod]
      public void GetId_ReturnVendorId_int()
      {
        string name = "Test Vendor";
        string description = "test vendor description";
        Vendor newVendor = new Vendor(name, description);
        int result = newVendor.Id;
        Assert.AreEqual(1, result);
      }

      [TestMethod]
      public void GetAll_ReturnAllVendorObjects_VendorList()
      {
      string name1 = "test vendor 1";
      string description1 = "test vendor description 1";
      Vendor newVendor1 = new Vendor(name1, description1);

      string name2 = "test vendor 2";
      string description2 = "test vendor description 2";
      Vendor newVendor2 = new Vendor(name2, description2);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
      }
      
      [TestMethod]
      public void Find_ReturnCorrectVendor_Vendor()
      {
      string name1 = "test vendor 1";
      string description1 = "test vendor description 1";
      Vendor newVendor1 = new Vendor(name1, description1);

      string name2 = "test vendor 2";
      string description2 = "test vendor description 2";
      Vendor newVendor2 = new Vendor(name2, description2);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      Vendor result = Vendor.Find(1);

      Assert.AreEqual(newVendor1, result);
      }

      [TestMethod]
      public void AddOrder_AssociatesOrderWithVendor_OrderList()
      {
        string title = "Order";
        string date = "09/29/1999";
        float price = 10F;
        string description = "this is the one";
        Order newOrder = new Order(title, date, price, description);
        List<Order> newList = new List<Order> { newOrder };

        string vendorName = "test vendor";
        string vendorDescription = "test vendor description";
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        newVendor.AddOrder(newOrder);
        
        List<Order> result = newVendor.Orders;

        CollectionAssert.AreEqual(newList, result);
      }

      [TestMethod]
      public void RemoveOrder_DeleteOrderAssociatedWithVendor_OrderList()
    {
      string title = "Order";
      string date = "09/29/1999";
      float price = 10F;
      string description = "this is the one";
      Order newOrder = new Order(title, date, price, description);

      string title2 = "Order2";
      string date2 = "12/24/2020";
      float price2 = 8F;
      string description2 = "this is the second";
      Order newOrder2 = new Order(title2, date2, price2, description2);

      List<Order> newList = new List<Order>{ newOrder2 };

      string vendorName = "test vendor";
      string vendorDescription = "test vendor description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      newVendor.AddOrder(newOrder);
      newVendor.AddOrder(newOrder2);
      newVendor.RemoveOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }   
}