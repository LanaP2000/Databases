
namespace Assignment1
{
    partial class MenuForm
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
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomers.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonCustomers.Location = new System.Drawing.Point(191, 90);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(246, 46);
            this.buttonCustomers.TabIndex = 0;
            this.buttonCustomers.Text = "Manage Customers";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBooks.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonBooks.Location = new System.Drawing.Point(191, 172);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(246, 46);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Manage Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonOrder.Location = new System.Drawing.Point(191, 253);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(246, 46);
            this.buttonOrder.TabIndex = 2;
            this.buttonOrder.Text = "Place Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonBooks);
            this.Controls.Add(this.buttonCustomers);
            this.ForeColor = System.Drawing.Color.Magenta;
            this.Name = "Form4";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonOrder;
    }
}