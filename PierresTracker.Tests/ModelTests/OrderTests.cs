using Microsoft. VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresTracker.Models;
using System;

namespace PierresTracker.Tests 
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTheOrderTitle_String()
    {
      string title = "Order";
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]

    public void GetAll_ReturnsAll_OrderList()
    {
      string titleOne = "title1";
      string titleTwo = "title2"; 
      Order newOrderOne = new Order(titleOne);
      Order newOrderTwo = new Order(titleTwo);
      List<Order> newOrders = new List<Order> { newOrderOne,  newOrderTwo };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrders, result);
    }

    [TestMethod]
    public void GetId_ReturnIdOfRecord_Int()
    {
      string title = "title";
      Order newOrder = new Order(title);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnOrderById_Order()
    {
      string titleOne = "title1";
      string titleTwo = "title2"; 
      Order newOrderOne = new Order(titleOne);
      Order newOrderTwo = new Order(titleTwo); 

      Order result = Order.Find(2);

      Assert.AreEqual(newOrderTwo, result);
    }

    [TestMethod]
      public void GetDescription_ReturnOrderDescription_Order()
      {
        string name = "Test Order1";
        Order newOrder = new Order(name);

        string description = "this is a test";
        newOrder.GetDescription(description);

        string result = newOrder.Description;


        Assert.AreEqual(result, description);
      }

      [TestMethod]
      public void GetPrice_ReturnOrderPrice_Order()
      {
        string name = "Test Order1";
        Order newOrder = new Order(name);

        int amount = 4;
        newOrder.Bread(amount);
        newOrder.Pastry(amount);

        int result = newOrder.Price;


        Assert.AreEqual(result, 27);
      }

      [TestMethod]
      public void GetAmount_ReturnOrderBreadAmount_Order()
      {
        string name = "Test Order1";
        Order newOrder = new Order(name);

        int amount = 4;
        newOrder.Bread(amount);

        int result = newOrder.BreadAmount;


        Assert.AreEqual(result, 6);
      }

      [TestMethod]
      public void GetAmount_ReturnOrderPastryAmount_Order()
      {
        string name = "Test Order1";
        Order newOrder = new Order(name);

        int amount = 4;
        newOrder.Pastry(amount);

        int result = newOrder.PastryAmount;


        Assert.AreEqual(result, 4);
      }

      [TestMethod]
      public void GetDate_ReturnOrderDate_Order()
      {
        string name = "Test name";
        Order newOrder = new Order(name);

        string date = "Dec, 18, 2020";
        newOrder.GetDate(date);

        string result = newOrder.Date;


        Assert.AreEqual(result, date);
      }
  }
}