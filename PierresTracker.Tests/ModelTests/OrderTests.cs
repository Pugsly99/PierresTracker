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
      Order newOrder = new Order("Test", "09/29/1999", 10F, "this is the one");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }


      [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsTheOrders_OrderList()
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

      List<Order> newList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      Assert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsExactOrder_Order()
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

      Order result = Order.Find(1);

      Assert.AreEqual(newOrder, result);
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