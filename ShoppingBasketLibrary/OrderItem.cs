using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Basket
{
    public class OrderItem
    {
        public const int MAX_QUANTITY = 1000000;

        // Private fields
        private string _productName;
        private decimal _latestPrice;
        private int _quantity;

        // Properties
        /// <summary>
        /// This returns the product name
        /// </summary>
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        /// <summary>
        /// This returns and sets the latest price
        /// </summary>
        public decimal LatestPrice
        {
            get { return _latestPrice; }
            set
            {
                // Exception
                if (value <= 0)
                {
                    throw new ArgumentException("Latest price is invalid. Latest price must be more than zero", "latestPrice");
                }

                _latestPrice = value;
            }
        }

        /// <summary>
        /// This returns the quantity
        /// </summary>
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                    _quantity = 0;
                else
                    _quantity = value;
            }
        }

        /// <summary>
        /// This returns the total price of the order items
        /// </summary>
        public decimal TotalOrder
        {
            get
            {
                // Working out the total price of order
                return LatestPrice * Quantity;
            }
        }


        // Constructor
        /// <summary>
        /// Constructor taking three arguments
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="latestPrice"></param>
        /// <param name="quantity"></param>
        public OrderItem(string productName, decimal latestPrice, int quantity) 
        {
            ProductName = productName;
            LatestPrice = latestPrice;
            Quantity = quantity;
        }

        /// <summary>
        /// Constructor taking two arguments defaulting quantity to 1
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="latestPrice"></param>
        public OrderItem(string productName, decimal latestPrice) : this(productName, latestPrice, 1)
        { }


        // Methods
        /// <summary>
        /// This returns the updated quantity
        /// </summary>
        /// <param name="latestPrice">Saves the latest price</param>
        /// <param name="quantity">Adds to the quantity</param>
        /// <returns></returns>
        public int AddItems(decimal latestPrice, int quantity)
        {
            // Exception
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity is invalid. Quantity must be more than zero", "quantity");
            }

            LatestPrice = latestPrice;
            if ((Quantity + quantity) > MAX_QUANTITY)
                Quantity = MAX_QUANTITY;
            else
                Quantity += quantity;

            return Quantity;
        }

        /// <summary>
        /// This returns the updated quantity
        /// </summary>
        /// <param name="quantity">Adds to the quantity</param>
        /// <returns></returns>
        public int AddItems(int quantity)
        {
            // Exception
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity is invalid. Quantity must be more than zero", "quantity");
            }

            if ((Quantity + quantity) > MAX_QUANTITY)
                Quantity = MAX_QUANTITY;
            else
                Quantity += quantity;

            return Quantity;
        }

        /// <summary>
        /// This updates the quantity by one and returns the updated quantity
        /// </summary>
        /// <returns></returns>
        public int AddItem()
        {
            Quantity++;
            return Quantity;
        }

        /// <summary>
        /// This returns the updated quantity
        /// </summary>
        /// <param name="numberOfItemsToBeRemoved">Removes from the quantity</param>
        /// <returns></returns>
        public int RemoveItems(int numberOfItemsToBeRemoved)
        {
            // Exception
            if (numberOfItemsToBeRemoved <= 0)
            {
                throw new ArgumentException("Number of items to be removed is invalid. Value must be more than zero", "numberOfItemsToBeRemoved");
            }

            Quantity -= numberOfItemsToBeRemoved;
            return Quantity;
        }

        /// <summary>
        /// This updates the quantity by removing one and returns the updated quantity
        /// </summary>
        /// <returns></returns>
        public int RemoveItem()
        {
            Quantity--;
            return Quantity;
        }

    }
}
