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
    public partial class MainForm : Form
    {
        // private field
        private Shopping_Basket.ShoppingBasket _basket;

        public MainForm()
        {
            InitializeComponent();
            _basket = new Shopping_Basket.ShoppingBasket();
        }

        // private method (ShowBasket) displaying the items onto the list-box
        private void ShowBasket()
        {
            lstBasket.Items.Clear();
            for (int i = 0; i < _basket.OrderItems.Count; i++)
            {
                string basketDetails = string.Format($"{_basket.OrderItems[i].ProductName,-25} {_basket.OrderItems[i].Quantity,-10} {_basket.OrderItems[i].LatestPrice,15:C2}");
                lstBasket.Items.Add(basketDetails);
            }

            txtNumberOfProducts.Text = _basket.NumberOfProducts.ToString();
            txtTotal.Text = _basket.BasketTotal.ToString("C2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantity = (int)nudQuantity.Value;
            decimal latestPrice;

            // validating the Product Name text box
            if (!string.IsNullOrWhiteSpace(productName))
            {
                lblErrorPN.Text = string.Empty;
            }
            else
            {
                lblErrorPN.Text = "Product Name is Invalid";
                return;
            }

            // validating the Quantity numeric up down box
            if (quantity > 0)
            {
                lblErrorQ.Text = string.Empty;
            }
            else
            {
                lblErrorQ.Text = "Quantity must be more than 0";
                return;
            }

            // validating the Latest Price text box
            if (decimal.TryParse(txtLatestPrice.Text, out latestPrice))
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

            // making sure the quantity doesn't exceed the maximum quantity limit
            for (int i = 0; i < _basket.OrderItems.Count; i++)
            {
                if (string.Equals(productName.Trim(), _basket.OrderItems[i].ProductName, StringComparison.InvariantCultureIgnoreCase))
                {
                    if (_basket.OrderItems[i].Quantity == OrderItem.MAX_QUANTITY)
                    {
                        lblErrorQ.Text = $"Quantity for '{_basket.OrderItems[i].ProductName}' can not\nbe more than 1,000,000";
                    }
                }
            }

            try
            {
                // adding product to the basket
                _basket.AddProduct(productName, latestPrice, quantity);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show($"{ex.Message}", "Shopping Basket");
            }

            // showing updated basket
            ShowBasket();

            this.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // checking if the list-box has items inside to remove 
            if (lstBasket.Items.Count > 0)
            {
                // checking if an item in the list-box has been selected before it can be removed
                if (lstBasket.SelectedItem != null)
                {
                    //  removing the selected item from the list_box
                    if (lstBasket.SelectedIndex >= 0)
                    {
                        OrderItem bsk = _basket.OrderItems[lstBasket.SelectedIndex];
                        _basket.RemoveProduct(bsk.ProductName);

                        // showing updated basket
                        ShowBasket();
                    }
                }
                else
                {
                    MessageBox.Show("Select and item in the basket to remove", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("There is nothing in the basket to remove", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // checking if the list-box has items inside to edit
            if (lstBasket.Items.Count > 0)
            {
                // checking if an item in the list-box has been selected before it can be edited
                if (lstBasket.SelectedItem != null)
                {
                    // editing the selected item from the list_box
                    OrderItem selectedItem = _basket.OrderItems[lstBasket.SelectedIndex];

                    EditBasketForm edit = new EditBasketForm(selectedItem, _basket);
                    if (edit.ShowDialog() == DialogResult.OK)
                    {
                        _basket.OrderItems[lstBasket.SelectedIndex].ProductName = edit.SelectedItem.ProductName;
                        _basket.OrderItems[lstBasket.SelectedIndex].Quantity = edit.SelectedItem.Quantity;
                        _basket.OrderItems[lstBasket.SelectedIndex].LatestPrice = edit.SelectedItem.LatestPrice;

                        // showing updated basket
                        ShowBasket();
                    }
                }
                else
                {
                    MessageBox.Show("Select and item in the basket to edit", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("There is nothing in the basket to edit", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearBasket_Click(object sender, EventArgs e)
        {
            // checking if the list-box has items inside to clear
            if (lstBasket.Items.Count > 0)
            {
                // clearing the list-box
                _basket.Clear();
                ShowBasket();
                lstBasket.Items.Clear();
            }
            else
            {
                MessageBox.Show("There is nothing to clear because the basket is empty", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // checking if the list-box has items inside to save
            if (lstBasket.Items.Count > 0)
            {
                // saving the items in the list-box into a text file
                string receipt;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text (*.txt) | *.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Saved: " + save.FileName, "Shopping Basket",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _basket.SaveBasket(save.FileName, out receipt);
                }
            }
            else
            {
                MessageBox.Show("There is nothing in the basket to save", "Shopping Basket",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // exiting the main form
            // Close() Calls MainForm_FormClosing Event.
            Close();
        }

        // Event: validating Latest Price text-box allowing it to accept only numbers and dot(.)
        private void txtLatestPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.') { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back; 
            }
        }

        // Event: validations for closing the main form
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit the shopping basket", "Shopping Basket",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.No)
                e.Cancel = true;
        }

    }
}
