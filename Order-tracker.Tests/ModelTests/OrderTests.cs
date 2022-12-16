using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "pastry";
      string description = "variety package";
      int price = 2000;
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "pastry";
      string description = "variety package";
      int price = 2000;
      string date = "12/16/2022";

      //Act
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "pastry";
      string description = "variety package";
      int price = 2000;
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "bread";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "pastry";
      string description = "variety package";
      int price = 2000;
      string date = "12/16/2022";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title1 = "pastry";
      string title2 = "bread";
      string description = "variety package";
      int price = 2000;
      string date = "12/16/2022";
      Order newOrder1 = new Order(title1, description, price, date);
      Order newOrder2 = new Order(title2, description, price, date);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}