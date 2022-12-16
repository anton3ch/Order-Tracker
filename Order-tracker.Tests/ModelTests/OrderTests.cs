using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tracker.Models;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class OrderTests
  {
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
  }
}