using Assignment2;
using System;
using System.Windows.Forms;

/// <summary>
/// Lana Pantskalashvili
/// 823358842
/// MenuForm class with all the necessary methods/functions to implement menu
/// </summary> 
/// 

namespace Assignment1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) { }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm store = new CustomerForm();
            store.ShowDialog();
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookForm store = new BookForm();
            store.ShowDialog();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 store = new Form1();
            store.ShowDialog();
        }
    }
}
