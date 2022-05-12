using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shopping_Basket.Tests
{
    [TestClass()]
    public class ShoppingBasketTest
    {
        #region MethodAddProductWithThreeArgumentsTests

        [TestMethod()]
        public void ThreeArgusAddProductTest_TestingIfEachProductIsOnTheList()
        {
            // Arrange
            int expected = 3;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 2);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            // Assert
            Assert.AreEqual(expected, sb.NumberOfProducts);

        }

        [TestMethod()]
        public void ThreeArgusAddProductTest_TestingIfAProductIsAlreadyInTheBasket()
        {
            // Arrange
            bool expected = true;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 2);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Apple", 0.50m, 2);

            // Assert
            Assert.AreEqual(expected, sb.IsProductInBasket("Apple"));

        }

        [TestMethod()]
        public void ThreeArgusAddProductTest_TestingIfAProductAlreadyInTheBasketHasBeenAdjusted()
        {
            // Arrange
            int expectedNumberOfProducts = 2;
            decimal expectedCurrentPrice = 0.50m;
            int expectedCurrentQuantity = 4;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 2);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Apple", 0.50m, 2);

            int actualNumberOfProduct = sb.NumberOfProducts;
            decimal actualCurrentPrice = sb.CurrentPrice("Apple");
            int actualCurrentQuantity = sb.CurrentQuantity("Apple");

            // Assert
            Assert.AreEqual(expectedNumberOfProducts, actualNumberOfProduct);
            Assert.AreEqual(expectedCurrentPrice, actualCurrentPrice);
            Assert.AreEqual(expectedCurrentQuantity, actualCurrentQuantity);

        }

        [TestMethod()]
        public void ThreeArgusAddProductTest_TestingIfCasesHaveBeenIgnored()
        {
            // Arrange
            int expected = 4;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 2);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("ApPlE", 1.00m, 2);

            // Assert
            Assert.AreEqual(expected, sb.CurrentQuantity("Apple"));
        }

        [TestMethod()]
        public void ThreeArgusAddProductTest_TestingIfSpacesHaveBeenTrimmed()
        {
            // Arrange
            int expected = 4;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 2);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("   Apple  ", 1.00m, 2);

            // Assert
            Assert.AreEqual(expected, sb.CurrentQuantity("Apple"));
        }

        // what if you add a product with no price? or no name?
        // price boundaries? and quantity boundaries
        #endregion

        #region MethodAddProductWithTwoArgumentsTests

        [TestMethod()]
        public void TwoArgusAddProductTest_TestingIfEachProductIsOnTheList()
        {
            // Arrange
            int expected = 3;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m);
            sb.AddProduct("Grape", 2.00m);
            sb.AddProduct("Pear", 1.50m);

            // Assert
            Assert.AreEqual(expected, sb.NumberOfProducts);

        }

        [TestMethod()]
        public void TwoArgusAddProductTest_TestingIfAProductIsAlreadyInTheBasket()
        {
            // Arrange
            bool expected = true;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m);
            sb.AddProduct("Grape", 2.00m);
            sb.AddProduct("Apple", 0.50m);

            // Assert
            Assert.AreEqual(expected, sb.IsProductInBasket("Apple"));

        }

        [TestMethod()]
        public void TwoArgusAddProductTest_TestingIfAProductAlreadyInTheBasketHasBeenAdjusted()
        {
            // Arrange
            int expectedNumberOfProducts = 2;
            decimal expectedCurrentPrice = 0.50m;
            int expectedCurrentQuantity = 2;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m);
            sb.AddProduct("Grape", 2.00m);
            sb.AddProduct("Apple", 0.50m);

            int actualNumberOfProducts = sb.NumberOfProducts;
            decimal actualCurrentPrice = sb.CurrentPrice("Apple");
            int actualCurrentQuantity = sb.CurrentQuantity("Apple");

            // Assert
            Assert.AreEqual(expectedNumberOfProducts, actualNumberOfProducts);
            Assert.AreEqual(expectedCurrentPrice, actualCurrentPrice);
            Assert.AreEqual(expectedCurrentQuantity, actualCurrentQuantity);

        }

        [TestMethod()]
        public void TwoArgusAddProductTest_TestingIfCasesHaveBeenIgnored()
        {
            // Arrange
            int expected = 2;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m);
            sb.AddProduct("Grape", 2.00m);
            sb.AddProduct("ApPlE", 1.00m);

            // Assert
            Assert.AreEqual(expected, sb.CurrentQuantity("Apple"));
        }

        [TestMethod()]
        public void TwoArgusAddProductTest_TestingIfSpacesHaveBeenTrimed()
        {
            // Arrange
            int expected = 2;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m);
            sb.AddProduct("Grape", 2.00m);
            sb.AddProduct("  Apple   ", 1.00m);

            // Assert
            Assert.AreEqual(expected, sb.CurrentQuantity("Apple"));
        }

        #endregion

        #region MethodRemoveProductWithTwoArgumentsTests

        [TestMethod()]
        public void TwoArgusRemoveProductTest_DeductingFromAProductQuantity()
        {
            // Arrange
            bool expected = true;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 3);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            bool actual = sb.RemoveProduct("Apple", 1);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TwoArgusRemoveProductTest_TestingIfProductHasBeenRemovedFromList()
        {
            // Arrange
            bool expected = true;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            bool actual = sb.RemoveProduct("Apple", 1);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TwoArgusRemoveProductTest_TestingIfProductNameDoesNotExist()
        {
            // Arrange
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            // Act
            bool actual = sb.RemoveProduct("Fish", 1);

            // Assert
            Assert.IsTrue(sb.OrderItems.Count == 3);

        }

        #endregion

        #region MethodRemoveProductWithOneArgumentTests

        [TestMethod()]
        public void OneArguRemoveProductTest_RemovingAProductFromTheList()
        {
            // Arrange
            bool expected = true;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 3);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            bool actual = sb.RemoveProduct("Apple");

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void OneArguRemoveProductTest_TestingIfProductNameDoesNotExist()
        {
            // Arrange
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);

            // Act
            bool actual = sb.RemoveProduct("Fish");

            // Assert
            Assert.IsTrue(sb.OrderItems.Count == 3);
        }

        #endregion

        #region MethodClearTest

        [TestMethod()]
        public void ClearTest_ClearingTheBasket()
        {
            // Arrange
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            // Act
            sb.Clear();

            // Assert
            Assert.AreEqual(0, sb.NumberOfItems);
            
        }

        #endregion

        #region MethodCurrentPriceTests

        [TestMethod()]
        public void CurrentPriceTest_TestingTheCurrentPriceOfASpecificProduct()
        {
            // Arrange
            decimal expected = 2.00m;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            decimal actual = sb.CurrentPrice("Grape");

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CurrentPriceTest_TestingIfProductNameDoesNotExist()
        {
            // Arrange

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            sb.CurrentPrice("Meat");

            // Assert
            // Assert is handled by exception

        }

        #endregion

        #region MethodCurrentQuantityTests

        [TestMethod()]
        public void CurrentQuantityTest_TestingTheCurrentQuantityOfASpecificProduct()
        {
            // Arrange
            int expected = 4;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 4);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            int actual = sb.CurrentQuantity("Apple");

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CurrentQuantityTest_TestingIfProductNameDoesNotExist()
        {
            // Arrange

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            sb.CurrentQuantity("Meat");

            // Assert
            // Assert is handled by exception

        }

        #endregion

        #region MethodIsProductInBasketTest

        [TestMethod()]
        public void IsProductInBasketTest_TestingIfProductIsInBasket()
        {
            // Arrange
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            // Act
            bool actual = sb.IsProductInBasket("Pear");

            // Assert
            Assert.IsTrue(actual);

        }

        [TestMethod()]
        public void IsProductInBasketTest_TestingIfProductIsNotInBasket()
        {
            // Arrange
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 1.00m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 0.50m, 2);
            sb.AddProduct("Lemon", 1.50m, 2);

            // Act
            bool actual = sb.IsProductInBasket("Meat");

            // Assert
            Assert.IsFalse(actual);

        }

        #endregion

        #region PropertiesTests(OtherTests)

        [TestMethod()]
        public void TestingTheNumberOfProductsInTheBasket()
        {
            // Arrange
            int expected = 5;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 0.50m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.00m, 2);
            sb.AddProduct("Toast", 1.50m, 2);
            sb.AddProduct("Meat", 3.00m, 2);

            int actual = sb.NumberOfProducts;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestingTheBasketTotal()
        {
            // Arrange
            decimal expected = 13.50m;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 0.50m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.00m, 2);
            sb.AddProduct("Toast", 1.50m, 2);
            sb.AddProduct("Meat", 3.00m, 2);

            decimal actual = sb.BasketTotal;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void TestingTheNumberOfItems()
        {
            // Arrange
            int expected = 8;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("Apple", 0.50m, 1);
            sb.AddProduct("Grape", 2.00m, 1);
            sb.AddProduct("Pear", 1.00m, 2);
            sb.AddProduct("Toast", 1.50m, 2);
            sb.AddProduct("Meat", 3.00m, 2);

            int actual = sb.NumberOfItems;

            // Assert
            Assert.AreEqual(expected, actual);

        }

        #endregion

        #region MethodSaveBasketTest

        [TestMethod()]
        public void SaveBasket_TestingIfItemsArePresentInShoppingBasket()
        {
            // Arrange
            string path = "";
            string receipt;
            bool expected = false;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            bool actual = sb.SaveBasket(path, out receipt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SaveBasket_TestingIfTheShoppingBasketReceiptHasBeenSavedInATemporaryTextFile()
        {
            // Arrange
            string path = Path.GetTempFileName();
            string receipt;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("apple", 1.00m, 2);
            sb.AddProduct("grape", 2.00m, 1);
            sb.AddProduct("pear", 1.50m, 2);
            sb.AddProduct("banana", 1.50m, 2);
            sb.AddProduct("grover", 1.50m, 2);
            sb.AddProduct("mango", 1.50m, 2);
            sb.AddProduct("orange", 1.50m, 2);
            sb.AddProduct("pineapple", 1.50m, 2);

            try
            {
                bool actual = sb.SaveBasket(path, out receipt);

                // Assert
                Assert.IsTrue(actual);
            }
            finally
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SaveBasket_TestingIfTheTextFileIsValid()
        {
            // Arrange
            string path = "****";
            string m;

            // Act
            ShoppingBasket sb = new ShoppingBasket();
            sb.AddProduct("apple", 10.00m, 2);

            sb.SaveBasket(path, out m);

            // Assert
            // Assert is handled by exception
        }

        #endregion

    }
}