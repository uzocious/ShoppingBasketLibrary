using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shopping_Basket
{
    public class ShoppingBasket
    {
        // private field
        private List<OrderItem> _orderItems;

        // Properties
        /// <summary>
        /// This returns the ordered items
        /// </summary>
        /// 
        public List<OrderItem> OrderItems
        {
            get { return _orderItems; }
            private set { _orderItems = value; }
        }

        /// <summary>
        /// This returns the total number of products in the shopping basket
        /// </summary>
        public int NumberOfProducts
        {
            get
            {
                // calculating and returning the total number of different Products in the basket
                return OrderItems.Count;
            }
        }

        /// <summary>
        /// This returns the current total price of the items in the basket
        /// </summary>
        public decimal BasketTotal
        {
            get
            {
                // calculating the total cost of all the items in the basket
                decimal totalBasketOrder = 0m;
                for (int i = 0; i < OrderItems.Count; i++)
                {
                    totalBasketOrder += OrderItems[i].TotalOrder;
                }
                return totalBasketOrder;
            }
        }

        /// <summary>
        /// This returns the total number of items on order in the shopping basket
        /// </summary>
        public int NumberOfItems
        {
            get
            {
                // calculating the total number of all the items in the basket
                int count = 0;
                for (int i = 0; i < OrderItems.Count; i++)
                {
                    count += OrderItems[i].Quantity;
                }
                return count;
            }
        }


        // Constructor
        /// <summary>
        /// Constructor taking a list of class OrderItems
        /// </summary>
        /// <param name="currentBasket">list of OrderItem class</param>
        public ShoppingBasket(List<OrderItem> currentBasket)
        {
            OrderItems = currentBasket;
        }

        /// <summary>
        /// Constructor taking nothing
        /// </summary>
        public ShoppingBasket() : this(new List<OrderItem>())
        { }


        //Methods
        /// <summary>
        /// This updates the shopping basket by adding to the it
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="latestPrice"></param>
        /// <param name="quantity"></param>
        public void AddProduct(string productName, decimal latestPrice, int quantity)
        {
            // Adding a product to the basket. If the product is already in the basket then  it's quantity is adjusted, otherwise
            // it will be added as a new OrderItem
            foreach (OrderItem item in OrderItems)
            {
                productName = productName.Trim();
                if (string.Equals(productName, item.ProductName, StringComparison.InvariantCultureIgnoreCase))
                {
                    item.AddItems(latestPrice, quantity);
                    return;
                }
            }

            productName = productName.Trim();
            OrderItems.Add(new OrderItem(productName, latestPrice, quantity));
        }

        /// <summary>
        /// This updates the shopping basket by adding to it
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="latestPrice"></param>
        public void AddProduct(string productName, decimal latestPrice)
        {
            // Adding a product to the basket assuming the quantity to be 1. If the product is already in the basket then
            // it's quantity is adjusted, otherwise it will be added as a new OrderItem 
            foreach (OrderItem item in OrderItems)
            {
                productName = productName.Trim();
                if (string.Equals(productName, item.ProductName, StringComparison.InvariantCultureIgnoreCase))
                {
                    item.AddItems(latestPrice, 1);
                    return;
                }
            }

            productName = productName.Trim();
            OrderItems.Add(new OrderItem(productName, latestPrice));
        }

        /// <summary>
        /// This returns a boolean if a product quantity has been deducted
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool RemoveProduct(string productName, int quantity)
        {
            // Removing the specified quantity of a product from the basket. 
            OrderItem itemToRemove = null;
            bool result = false;

            foreach (OrderItem item in OrderItems)
            {
                if (item.ProductName == productName)
                {
                    item.RemoveItems(quantity);
                    if (item.Quantity < 1)
                    {
                        itemToRemove = item;
                    }
                    result = true;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                OrderItems.Remove(itemToRemove);
            }

            return result;
        }

        /// <summary>
        /// This returns a boolean if product has been removed from shopping basket
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public bool RemoveProduct(string productName)
        {
            // Removing an entire product from the basket
            OrderItem itemToRemove = null;
            bool result = false;

            foreach (OrderItem item in OrderItems)
            {
                if (item.ProductName == productName)
                {
                    itemToRemove = item;
                    result = true;
                    break;
                }
            }

            if (itemToRemove != null)
            {
                OrderItems.Remove(itemToRemove);
            }

            return result;
        }

        /// <summary>
        /// This clears the shopping basket
        /// </summary>
        public void Clear()
        {
            // Emptying basket of all products
            OrderItems.Clear();
        }

        /// <summary>
        /// This returns the latest price of a product
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public decimal CurrentPrice(string productName)
        {
            // Returning the current price of the specified product. 
            decimal itemPrice = 0m;
            bool productFound = false;

            foreach (OrderItem item in OrderItems)
            {
                if (item.ProductName == productName)
                {
                    itemPrice = item.LatestPrice;
                    productFound = true;
                }
            }

            if (!productFound)
            {
                throw new ArgumentException("Product name doesn't exist in the basket", "productName");
            }

            return itemPrice;
        }

        /// <summary>
        /// This returns the latest quantity of a product
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public int CurrentQuantity(string productName)
        {
            // Returning the current quantity of the specified product. 
            int itemQuantity = 0;
            bool productFound = false;

            foreach (OrderItem item in OrderItems)
            {
                if (item.ProductName == productName)
                {
                    itemQuantity = item.Quantity;
                    productFound = true;
                }
            }

            if (!productFound)
            {
                throw new ArgumentException("Product name doesn't exist in the basket", "productName");
            }

            return itemQuantity;
        }

        /// <summary>
        /// This returns a boolean if a product is currently in the shopping basket
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public bool IsProductInBasket(string productName)
        {
            // Checking to see if specified product is in the basket
            foreach (OrderItem item in OrderItems)
            {
                if (item.ProductName == productName)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// This saves the shopping basket items into a text file and returns a boolean value
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="recipt"></param>
        /// <returns></returns>
        public bool SaveBasket(string fileName, out string receipt)
        {
            // Saving shopping basket into a text file
            bool result = false;
            receipt = string.Empty;

            if (this.OrderItems.Count <= 0)
                return result;

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                string pName = "Product Name";
                string Quantity = "Quantity";
                string lPrice = "Latest Price";
                string Total = "Total";

                sw.WriteLine("*** SHOPPING BASKET RECEIPT ***"); sw.WriteLine(); 
                sw.WriteLine($"{pName, -25} {Quantity, -10} {lPrice, 15} {Total, 25}");

                for (int i = 0; i < OrderItems.Count; i++)
                {
                    receipt = string.Format($"{OrderItems[i].ProductName,-25} {OrderItems[i].Quantity,-10} {OrderItems[i].LatestPrice,15:C2} {OrderItems[i].TotalOrder,25:C2}");
                    sw.WriteLine(receipt);
                    result = true;
                }

                sw.WriteLine(); sw.WriteLine();
                sw.WriteLine($"Number of Products: {NumberOfProducts}"); sw.WriteLine($"Number of Items: {NumberOfItems}"); sw.WriteLine($"Total: {BasketTotal:C2}");
                sw.Flush();
            }

            return result;
        }

    }
}
