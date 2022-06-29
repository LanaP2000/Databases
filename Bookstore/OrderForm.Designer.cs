
namespace Assignment2
{
    partial class Form1
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.buttonAddTitle = new System.Windows.Forms.Button();
            this.buttonConfirmOrder = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.textSubtotal = new System.Windows.Forms.TextBox();
            this.textTax = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.castButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.myBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinesTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox.CausesValidation = false;
            this.comboBox.DisplayMember = "Title";
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(118, 89);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(335, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "Select a Title";
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // textAuthor
            // 
            this.textAuthor.BackColor = System.Drawing.Color.LightGray;
            this.textAuthor.Location = new System.Drawing.Point(289, 140);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.ReadOnly = true;
            this.textAuthor.Size = new System.Drawing.Size(187, 20);
            this.textAuthor.TabIndex = 1;
            // 
            // textISBN
            // 
            this.textISBN.BackColor = System.Drawing.Color.LightGray;
            this.textISBN.Location = new System.Drawing.Point(614, 140);
            this.textISBN.Name = "textISBN";
            this.textISBN.ReadOnly = true;
            this.textISBN.Size = new System.Drawing.Size(193, 20);
            this.textISBN.TabIndex = 2;
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.LightGray;
            this.textPrice.Location = new System.Drawing.Point(482, 171);
            this.textPrice.Name = "textPrice";
            this.textPrice.ReadOnly = true;
            this.textPrice.Size = new System.Drawing.Size(117, 20);
            this.textPrice.TabIndex = 3;
            // 
            // textQuantity
            // 
            this.textQuantity.BackColor = System.Drawing.Color.LightGray;
            this.textQuantity.Location = new System.Drawing.Point(511, 220);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(59, 20);
            this.textQuantity.TabIndex = 4;
            this.textQuantity.TextChanged += new System.EventHandler(this.textQuantity_TextChanged_1);
            // 
            // buttonAddTitle
            // 
            this.buttonAddTitle.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonAddTitle.Location = new System.Drawing.Point(459, 267);
            this.buttonAddTitle.Name = "buttonAddTitle";
            this.buttonAddTitle.Size = new System.Drawing.Size(149, 23);
            this.buttonAddTitle.TabIndex = 5;
            this.buttonAddTitle.Text = "Add Title";
            this.buttonAddTitle.UseVisualStyleBackColor = true;
            this.buttonAddTitle.Click += new System.EventHandler(this.buttonAddTitle_Click_1);
            // 
            // buttonConfirmOrder
            // 
            this.buttonConfirmOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonConfirmOrder.Location = new System.Drawing.Point(289, 581);
            this.buttonConfirmOrder.Name = "buttonConfirmOrder";
            this.buttonConfirmOrder.Size = new System.Drawing.Size(138, 23);
            this.buttonConfirmOrder.TabIndex = 6;
            this.buttonConfirmOrder.Text = "Confirm Order";
            this.buttonConfirmOrder.UseVisualStyleBackColor = true;
            this.buttonConfirmOrder.Click += new System.EventHandler(this.buttonConfirmOrder_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonCancelOrder.Location = new System.Drawing.Point(623, 581);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(145, 23);
            this.buttonCancelOrder.TabIndex = 7;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // textSubtotal
            // 
            this.textSubtotal.BackColor = System.Drawing.Color.LightGray;
            this.textSubtotal.Location = new System.Drawing.Point(255, 531);
            this.textSubtotal.Name = "textSubtotal";
            this.textSubtotal.ReadOnly = true;
            this.textSubtotal.Size = new System.Drawing.Size(109, 20);
            this.textSubtotal.TabIndex = 8;
            // 
            // textTax
            // 
            this.textTax.BackColor = System.Drawing.Color.LightGray;
            this.textTax.Location = new System.Drawing.Point(482, 531);
            this.textTax.Name = "textTax";
            this.textTax.ReadOnly = true;
            this.textTax.Size = new System.Drawing.Size(117, 20);
            this.textTax.TabIndex = 9;
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.LightGray;
            this.textTotal.Location = new System.Drawing.Point(686, 531);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(121, 20);
            this.textTotal.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.myBookID,
            this.Title,
            this.myPrice,
            this.myQTY,
            this.Customer,
            this.myCustomerID,
            this.LinesTotal});
            this.dataGridView1.Location = new System.Drawing.Point(164, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 141);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelAuthor.Location = new System.Drawing.Point(242, 147);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(41, 13);
            this.labelAuthor.TabIndex = 12;
            this.labelAuthor.Text = "Author:";
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(573, 147);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(35, 13);
            this.labelISBN.TabIndex = 13;
            this.labelISBN.Text = "ISBN:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(442, 174);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity:";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(203, 538);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 16;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(451, 538);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(25, 13);
            this.labelTax.TabIndex = 17;
            this.labelTax.Text = "Tax";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(649, 538);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Order Summary";
            // 
            // castButton
            // 
            this.castButton.BackColor = System.Drawing.Color.LightPink;
            this.castButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.castButton.Location = new System.Drawing.Point(810, 643);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(171, 23);
            this.castButton.TabIndex = 20;
            this.castButton.Text = "SHOW CUSTOMER PAGE";
            this.castButton.UseVisualStyleBackColor = false;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(12, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SHOW BOOK PAGE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Select a Customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.Color.DeepPink;
            this.backButton.Location = new System.Drawing.Point(895, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // myBookID
            // 
            this.myBookID.HeaderText = "Book_ID";
            this.myBookID.Name = "myBookID";
            this.myBookID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // myPrice
            // 
            this.myPrice.HeaderText = "Price";
            this.myPrice.Name = "myPrice";
            this.myPrice.ReadOnly = true;
            // 
            // myQTY
            // 
            this.myQTY.HeaderText = "QTY";
            this.myQTY.Name = "myQTY";
            this.myQTY.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            // 
            // myCustomerID
            // 
            this.myCustomerID.HeaderText = "Customer_ID";
            this.myCustomerID.Name = "myCustomerID";
            // 
            // LinesTotal
            // 
            this.LinesTotal.HeaderText = "Line Total";
            this.LinesTotal.Name = "LinesTotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(993, 678);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textTax);
            this.Controls.Add(this.textSubtotal);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.buttonConfirmOrder);
            this.Controls.Add(this.buttonAddTitle);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.comboBox);
            this.Name = "Form1";
            this.Text = "ArkhamBooks Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button buttonAddTitle;
        private System.Windows.Forms.Button buttonConfirmOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.TextBox textSubtotal;
        private System.Windows.Forms.TextBox textTax;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button backButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn myBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn myPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn myQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn myCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinesTotal;
    }
}

