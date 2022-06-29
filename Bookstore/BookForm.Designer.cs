
namespace Assignment1
{
    partial class BookForm
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNewBook = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.Color.LightGray;
            this.textTitle.Location = new System.Drawing.Point(123, 137);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(377, 20);
            this.textTitle.TabIndex = 0;
            // 
            // textAuthor
            // 
            this.textAuthor.BackColor = System.Drawing.Color.LightGray;
            this.textAuthor.Location = new System.Drawing.Point(123, 193);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(316, 20);
            this.textAuthor.TabIndex = 1;
            // 
            // textISBN
            // 
            this.textISBN.BackColor = System.Drawing.Color.LightGray;
            this.textISBN.Location = new System.Drawing.Point(123, 251);
            this.textISBN.Name = "textISBN";
            this.textISBN.Size = new System.Drawing.Size(132, 20);
            this.textISBN.TabIndex = 2;
            // 
            // textPrice
            // 
            this.textPrice.BackColor = System.Drawing.Color.LightGray;
            this.textPrice.Location = new System.Drawing.Point(123, 303);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(132, 20);
            this.textPrice.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(377, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Edit an Existing Book";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonBack.Location = new System.Drawing.Point(687, 48);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNewBook
            // 
            this.buttonNewBook.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonNewBook.Location = new System.Drawing.Point(687, 89);
            this.buttonNewBook.Name = "buttonNewBook";
            this.buttonNewBook.Size = new System.Drawing.Size(75, 23);
            this.buttonNewBook.TabIndex = 6;
            this.buttonNewBook.Text = "New Book";
            this.buttonNewBook.UseVisualStyleBackColor = true;
            this.buttonNewBook.Click += new System.EventHandler(this.buttonNewBook_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonSave.Location = new System.Drawing.Point(687, 134);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonCancel.Location = new System.Drawing.Point(687, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ISBN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNewBook);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textISBN);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textTitle);
            this.Name = "Form3";
            this.Text = "frmBook";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNewBook;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}