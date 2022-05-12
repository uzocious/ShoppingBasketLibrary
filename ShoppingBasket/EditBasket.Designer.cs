namespace ShoppingBasketUI
{
    partial class EditBasketForm
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
            this.txtEditProductName = new System.Windows.Forms.TextBox();
            this.txtEditLatestPrice = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nudEditQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblErrorPN = new System.Windows.Forms.Label();
            this.lblErrorLP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latest Price";
            // 
            // txtEditProductName
            // 
            this.txtEditProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEditProductName.Location = new System.Drawing.Point(113, 16);
            this.txtEditProductName.MaxLength = 20;
            this.txtEditProductName.Name = "txtEditProductName";
            this.txtEditProductName.Size = new System.Drawing.Size(150, 20);
            this.txtEditProductName.TabIndex = 0;
            // 
            // txtEditLatestPrice
            // 
            this.txtEditLatestPrice.Location = new System.Drawing.Point(113, 111);
            this.txtEditLatestPrice.MaxLength = 7;
            this.txtEditLatestPrice.Name = "txtEditLatestPrice";
            this.txtEditLatestPrice.Size = new System.Drawing.Size(100, 20);
            this.txtEditLatestPrice.TabIndex = 2;
            this.txtEditLatestPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditLatestPrice_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(46, 167);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(74, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOK, "OK");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.toolTip1.SetToolTip(this.btnCancel, "Close");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudEditQuantity
            // 
            this.nudEditQuantity.Location = new System.Drawing.Point(113, 63);
            this.nudEditQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEditQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEditQuantity.Name = "nudEditQuantity";
            this.nudEditQuantity.Size = new System.Drawing.Size(100, 20);
            this.nudEditQuantity.TabIndex = 1;
            this.nudEditQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblErrorPN
            // 
            this.lblErrorPN.AutoSize = true;
            this.lblErrorPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPN.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPN.Location = new System.Drawing.Point(110, 39);
            this.lblErrorPN.Name = "lblErrorPN";
            this.lblErrorPN.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPN.TabIndex = 19;
            // 
            // lblErrorLP
            // 
            this.lblErrorLP.AutoSize = true;
            this.lblErrorLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorLP.ForeColor = System.Drawing.Color.Red;
            this.lblErrorLP.Location = new System.Drawing.Point(110, 134);
            this.lblErrorLP.Name = "lblErrorLP";
            this.lblErrorLP.Size = new System.Drawing.Size(0, 13);
            this.lblErrorLP.TabIndex = 21;
            // 
            // EditBasketForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(279, 218);
            this.Controls.Add(this.lblErrorLP);
            this.Controls.Add(this.lblErrorPN);
            this.Controls.Add(this.nudEditQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEditLatestPrice);
            this.Controls.Add(this.txtEditProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditBasketForm";
            this.Text = " Edit Basket";
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditProductName;
        private System.Windows.Forms.TextBox txtEditLatestPrice;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown nudEditQuantity;
        private System.Windows.Forms.Label lblErrorPN;
        private System.Windows.Forms.Label lblErrorLP;
    }
}