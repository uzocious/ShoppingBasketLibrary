using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shopping_Basket;

namespace ShoppingBasketUI
{
    public partial class EditBasketForm : Form
    {
        // Properties
        public OrderItem SelectedItem { get; private set; }
        public ShoppingBasket Basket { get; private set; }
        public EditBasketForm(OrderItem selectedItem, ShoppingBasket basket)
        {
            Basket = basket;
            SelectedItem = selectedItem;
            InitializeComponent();
            SetTextBoxes();
        }

        private void SetTextBoxes()
        {
            txtEditProductName.Text = SelectedItem.ProductName;
            txtEditLatestPrice.Text = SelectedItem.LatestPrice.ToString();
            nudEditQuantity.Value = SelectedItem.Quantity;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // validating the Product Name text-box
            if (!string.IsNullOrWhiteSpace(txtEditProductName.Text))
            {
                lblErrorPN.Text = string.Empty;
            }
            else
            {
                lblErrorPN.Text = "Product Name is Invalid";
                return;
            }
            // checking if the edit product already exists in the basket
            for (int i = 0; i < Basket.OrderItems.Count; i++)
            {
                if (string.Equals(txtEditProductName.Text.Trim(), Basket.OrderItems[i].ProductName, StringComparison.CurrentCultureIgnoreCase)
                    && txtEditProductName.Text != SelectedItem.ProductName)
                {
                    MessageBox.Show($"'{Basket.OrderItems[i].ProductName}' already exists in the basket",
                        "Shopping Basket", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // validating the Latest Price text-box
            decimal latestPrice;
            if (decimal.TryParse(txtEditLatestPrice.Text, out latestPrice))
            {
                if (latestPrice > 0)
                {
                    lblErrorLP.Text = string.Empty;
                }
                else
                {
                    lblErrorLP.Text = "Latest Price must be more than 0";
                    return;
                }
            }
            else
            {
                lblErrorLP.Text = "Latest Price is Invalid";
                return;
            }

            // setting the selected item to the changes made
            SelectedItem.ProductName = txtEditProductName.Text.Trim();
            SelectedItem.Quantity = (int)nudEditQuantity.Value;
            SelectedItem.LatestPrice = latestPrice;

            // setting the dialogue result to OK
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // closing the edit form
            Close();
        }

        // Event: validating Latest Price text-box allowing it to accept only numbers and dot(.)
        private void txtEditLatestPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.') { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

    }
}
