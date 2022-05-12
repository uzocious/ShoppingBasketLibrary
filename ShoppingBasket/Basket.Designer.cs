namespace ShoppingBasketUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBasket = new System.Windows.Forms.ListBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtLatestPrice = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfProducts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClearBasket = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblErrorPN = new System.Windows.Forms.Label();
            this.lblErrorQ = new System.Windows.Forms.Label();
            this.lblErrorLP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latest Price";
            // 
            // lstBasket
            // 
            this.lstBasket.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBasket.FormattingEnabled = true;
            this.lstBasket.ItemHeight = 19;
            this.lstBasket.Location = new System.Drawing.Point(22, 131);
            this.lstBasket.Name = "lstBasket";
            this.lstBasket.Size = new System.Drawing.Size(494, 270);
            this.lstBasket.TabIndex = 4;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(18, 48);
            this.txtProductName.MaxLength = 20;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(150, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // txtLatestPrice
            // 
            this.txtLatestPrice.Location = new System.Drawing.Point(412, 48);
            this.txtLatestPrice.MaxLength = 7;
            this.txtLatestPrice.Name = "txtLatestPrice";
            this.txtLatestPrice.Size = new System.Drawing.Size(100, 20);
            this.txtLatestPrice.TabIndex = 2;
            this.txtLatestPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatestPrice_KeyPress);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(243, 49);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(114, 20);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Products";
            // 
            // txtNumberOfProducts
            // 
            this.txtNumberOfProducts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumberOfProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNumberOfProducts.Location = new System.Drawing.Point(126, 423);
            this.txtNumberOfProducts.Name = "txtNumberOfProducts";
            this.txtNumberOfProducts.ReadOnly = true;
            this.txtNumberOfProducts.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfProducts.TabIndex = 9;
            this.txtNumberOfProducts.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotal.Location = new System.Drawing.Point(395, 423);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.Text = "£0.00";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(541, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Adds product to basket");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(541, 131);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 34);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.toolTip1.SetToolTip(this.btnRemove, "Removes product from basket");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(541, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.btnEdit, "Edits a product from basket");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.Location = new System.Drawing.Point(541, 238);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.Size = new System.Drawing.Size(75, 37);
            this.btnClearBasket.TabIndex = 7;
            this.btnClearBasket.Text = "Clear Basket";
            this.toolTip1.SetToolTip(this.btnClearBasket, "Clears the basket");
            this.btnClearBasket.UseVisualStyleBackColor = true;
            this.btnClearBasket.Click += new System.EventHandler(this.btnClearBasket_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(541, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "Saves the basket");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(541, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Close");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Basket";
            // 
            // lblErrorPN
            // 
            this.lblErrorPN.AutoSize = true;
            this.lblErrorPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPN.Location = new System.Drawing.Point(18, 81);
            this.lblErrorPN.Name = "lblErrorPN";
            this.lblErrorPN.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPN.TabIndex = 18;
            // 
            // lblErrorQ
            // 
            this.lblErrorQ.AutoSize = true;
            this.lblErrorQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQ.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQ.Location = new System.Drawing.Point(240, 81);
            this.lblErrorQ.Name = "lblErrorQ";
            this.lblErrorQ.Size = new System.Drawing.Size(0, 13);
            this.lblErrorQ.TabIndex = 19;
            // 
            // lblErrorLP
            // 
            this.lblErrorLP.AutoSize = true;
            this.lblErrorLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLP.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLP.Location = new System.Drawing.Point(409, 81);
            this.lblErrorLP.Name = "lblErrorLP";
            this.lblErrorLP.Size = new System.Drawing.Size(0, 13);
            this.lblErrorLP.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(638, 464);
            this.Controls.Add(this.lblErrorLP);
            this.Controls.Add(this.lblErrorQ);
            this.Controls.Add(this.lblErrorPN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearBasket);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberOfProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtLatestPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lstBasket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shopping Basket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBasket;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtLatestPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfProducts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClearBasket;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblErrorPN;
        private System.Windows.Forms.Label lblErrorQ;
        private System.Windows.Forms.Label lblErrorLP;
    }
}

