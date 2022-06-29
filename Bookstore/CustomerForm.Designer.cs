
namespace Assignment1
{
    partial class CustomerForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textFirstname = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Edit an Existing Customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textFirstname
            // 
            this.textFirstname.BackColor = System.Drawing.Color.LightGray;
            this.textFirstname.Location = new System.Drawing.Point(69, 93);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(227, 20);
            this.textFirstname.TabIndex = 1;
            // 
            // textLastname
            // 
            this.textLastname.BackColor = System.Drawing.Color.LightGray;
            this.textLastname.Location = new System.Drawing.Point(387, 93);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(256, 20);
            this.textLastname.TabIndex = 2;
            // 
            // textAddress
            // 
            this.textAddress.BackColor = System.Drawing.Color.LightGray;
            this.textAddress.Location = new System.Drawing.Point(69, 160);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(574, 20);
            this.textAddress.TabIndex = 3;
            // 
            // textCity
            // 
            this.textCity.BackColor = System.Drawing.Color.LightGray;
            this.textCity.Location = new System.Drawing.Point(69, 228);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(246, 20);
            this.textCity.TabIndex = 4;
            // 
            // textPhone
            // 
            this.textPhone.BackColor = System.Drawing.Color.LightGray;
            this.textPhone.Location = new System.Drawing.Point(69, 301);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(246, 20);
            this.textPhone.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.textEmail.Location = new System.Drawing.Point(69, 369);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(426, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textState
            // 
            this.textState.BackColor = System.Drawing.Color.LightGray;
            this.textState.Location = new System.Drawing.Point(399, 228);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(96, 20);
            this.textState.TabIndex = 7;
            // 
            // textZip
            // 
            this.textZip.BackColor = System.Drawing.Color.LightGray;
            this.textZip.Location = new System.Drawing.Point(543, 228);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(100, 20);
            this.textZip.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.ForeColor = System.Drawing.Color.DeepPink;
            this.backButton.Location = new System.Drawing.Point(703, 50);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newButton
            // 
            this.newButton.ForeColor = System.Drawing.Color.DeepPink;
            this.newButton.Location = new System.Drawing.Point(703, 103);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New Customer";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.ForeColor = System.Drawing.Color.DeepPink;
            this.saveButton.Location = new System.Drawing.Point(703, 157);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.ForeColor = System.Drawing.Color.DeepPink;
            this.cancelButton.Location = new System.Drawing.Point(703, 214);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Zip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form2";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textFirstname;
        private System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}