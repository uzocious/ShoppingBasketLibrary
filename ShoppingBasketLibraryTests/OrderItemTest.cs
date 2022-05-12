using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Basket.Tests
{
    [TestClass()]
    public class OrderItemTest
    {
        #region ConstructorTests

        [TestMethod()]
        public void ConstructorTest_VaidInputIncludingQuantity()
        {
            // Arrange
            string expectedProductName = "Orange";
            decimal expectedLatestPrice = 1.00m;
            int expectedQuantity = 2;

            // Act
            OrderItem oi = new OrderItem(expectedProductName, expectedLatestPrice, expectedQuantity);

            // Assert
            Assert.AreEqual(expectedProductName, oi.ProductName);
            Assert.AreEqual(expectedLatestPrice, oi.LatestPrice);
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        public void ConstructorTest_VaidInputExcludingQuantity()
        {
            // Arrange
            string expectedProductName = "Orange";
            decimal expectedLatestPrice = 1.00m;
            int expectedQuantity = 1;

            // Act
            OrderItem oi = new OrderItem(expectedProductName, expectedLatestPrice);

            // Assert
            Assert.AreEqual(expectedProductName, oi.ProductName);
            Assert.AreEqual(expectedLatestPrice, oi.LatestPrice);
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        public void ConstructorTest_InvalidQuantity()
        {
            // Arrange
            string expectedProductName = "Orange";
            decimal expectedLatestPrice = 1.00m;
            int expectedQuantity = 0;

            // Act
            OrderItem oi = new OrderItem(expectedProductName, expectedLatestPrice, -1);

            // Assert
            Assert.AreEqual(expectedProductName, oi.ProductName);
            Assert.AreEqual(expectedLatestPrice, oi.LatestPrice);
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorTest_InvalidLatestPrice()
        {
            // Arrange

            // Act
            OrderItem oi = new OrderItem("Orange", 0.00m, 2);

            // Assert
            // Assert is handled by exception
        }

        #endregion

        #region MethodAddItemsWithTwoArgumentsTests

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoArgusAddItemsTest_InvalidLatestPriceAndInvalidQuantity()
        {
            // Arrange
            OrderItem oi = new OrderItem("Apple", 1.50m, 2);

            // Act
            oi.AddItems(-1.00m, -1);

            // Assert
            // Assert is handled by exception
        }

        [TestMethod()]
        public void TwoArgusAddItemsTest_ValidLatestPrice()
        {
            // Arrange
            decimal expectedLatestPrice = 3.50m;

            // Act
            OrderItem oi = new OrderItem("Apple", 1.50m, 2);
            oi.AddItems(expectedLatestPrice, 1);

            // Assert
            Assert.AreEqual(expectedLatestPrice, oi.LatestPrice);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoArgusAddItemsTest_InvalidLatestPrice()
        {
            // Arrange
            OrderItem oi = new OrderItem("Apple", 1.50m, 2);

            // Act
            oi.AddItems(-1.00m, 1);

            // Assert
            // Assert is handled by exception
        }

        [TestMethod()]
        public void TwoArgusAddItemsTest_ValidQuantity()
        {
            // Arrange
            decimal expectedQuantity = 4;

            // Act
            OrderItem oi = new OrderItem("Apple", 1.50m, 2);
            oi.AddItems(2.00m, 2);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoArgusAddItemsTest_InvalidQuantity()
        {
            // Arrange
            OrderItem oi = new OrderItem("Apple", 1.50m, 2);

            // Act
            oi.AddItems(2.00m, 0);

            // Assert
            // Assert is handled by exception
        }

        [TestMethod()]
        public void TwoArgusAddItemsTest_TestingIfQuantityIsGreaterThanMaxQuantity()
        {
            // Arrange
            int expectedQuantity = OrderItem.MAX_QUANTITY;

            // Act
            OrderItem oi = new OrderItem("Apple", 1.50m, 10);
            oi.AddItems(2.00m, expectedQuantity);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        #endregion

        #region MethodAddItemsWithOneArgumentTests

        [TestMethod()]
        public void OneArguAddItemsTest_ValidQuantity()
        {
            // Arrange
            int expectedQuantity = 3;

            // Act
            OrderItem oi = new OrderItem("Pear", 1.00m, 2);
            oi.AddItems(1);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OneArguAddItemsTest_InvalidQuantity()
        {
            // Arrange
            OrderItem oi = new OrderItem("Pear", 1.00m, 2);

            // Act
            oi.AddItems(0);

            // Assert
            // Assert is handled by exception
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OneArguAddItemsTest_NegativeQuantity()
        {
            // Arrange
            OrderItem oi = new OrderItem("Pear", 1.00m, 2);

            // Act
            oi.AddItems(-1);

            // Assert
            // Assert is handled by exception
        }

        [TestMethod()]
        public void OneArguAddItemsTest_TestingIfQuantityIsGreaterThanMaxQuantity()
        {
            // Arrange
            int expectedQuantity = OrderItem.MAX_QUANTITY;

            // Act
            OrderItem oi = new OrderItem("Apple", 1.50m, 5);
            oi.AddItems(expectedQuantity);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        #endregion

        #region MethodAddItemTest

        [TestMethod()]
        public void AddItemTest_IncreasingQuantity()
        {
            // Arrange
            int expectedQuantity = 2;

            // Act
            OrderItem oi = new OrderItem("Pear", 1.00m);
            oi.AddItem();

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        #endregion

        #region MethodRemoveItemsTests

        [TestMethod()]
        public void RemoveItemsTest_ValidNumberOfItemsToBeRemoved()
        {
            // Arrange
            int expectedQuantity = 2;

            // Act
            OrderItem oi = new OrderItem("Grape", 1.00m, 3);
            oi.RemoveItems(1);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        public void RemoveItemsTest_InvalidNumberOfItemsToBeRemoved()
        {
            // Arrange
            int expectedQuantity = 0;

            // Act
            OrderItem oi = new OrderItem("Grape", 1.00m, 2);
            oi.RemoveItems(4);

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveItemsTest_NegativeNumberOfItemsToBeRemoved()
        {
            // Arrange
            OrderItem oi = new OrderItem("Pear", 1.00m, 2);

            // Act
            oi.AddItems(-1);

            // Assert
            // Assert is handled by exception
        }

        #endregion

        #region MethodRemoveItemTest

        [TestMethod()]
        public void RemoveItemTest_DecreasingQuantity()
        {
            // Arrange
            int expectedQuantity = 2;

            // Act
            OrderItem oi = new OrderItem("Grape", 1.00m, 3);
            oi.RemoveItem();

            // Assert
            Assert.AreEqual(expectedQuantity, oi.Quantity);
        }

        #endregion

        #region TotalOrderTest

        [TestMethod()]
        public void TotalAmountOfOrder()
        {
            // Arrange
            decimal expected = 2.00m;

            // Act 
            OrderItem oi = new OrderItem("Pineapple", 1.00m, 2);
            decimal actual = oi.TotalOrder;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}