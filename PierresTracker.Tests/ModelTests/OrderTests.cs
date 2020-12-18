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
  }
}