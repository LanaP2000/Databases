using System;
using System.Windows.Forms;
using System.IO;
using Assignment1;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Collections.Generic;

/// <summary>
/// Lana Pantskalashvili
/// 823358842
/// OrderForm class with all the necessary methods/functions to implement order summary page
/// </summary>

namespace Assignment2
{
    
    public partial class Form1 : Form
    {
        public double subTotal = 0;
        int Quantity;
        private readonly DataSet bookSet = new DataSet();
        private readonly DataSet customerSet = new DataSet();
        private ArrayList CustID { get; set; }

        private ArrayList BookID { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Loading comboBox with book titles
        {
            FillCustomerComboBox();
            FillBookComboBox();
        }
        
        public void FileWriter() // Writing order in a file
        {
            try
            {
                using (FileStream fs = new FileStream("orders.txt", FileMode.OpenOrCreate, FileAccess.Write)) //Opening or creating orders.txt file
                {
                    lock (fs) //To avoid unnecessary information
                    {
                        fs.SetLength(0);
                    }
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("      <<<<<<<<<<<<            Order Summary            >>>>>>>>>>>>      ");
                        sw.WriteLine("\n\n");
                       
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) //Looping through datagridview columns
                        {
                            sw.Write(String.Format("{0,0}.", i + 1));
                            for (int j = 0; j < 7; j++) //Looping through datagridview rows
                            {
                                string text = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value); //Reading datagridview cell values
                                if (j == 4)
                                    sw.WriteLine("      |Customer: {0}|\n", text);
                                else if (j == 0)
                                    sw.WriteLine("    |BookID: {0}|\n", text);
                                else if (j == 1)
                                    sw.WriteLine("      |Title: \"{0}\"|\n", text);
                                else if (j == 2)
                                    sw.WriteLine("      |Price: {0}|\n", text);
                                else if (j == 3)
                                    sw.WriteLine("      |QTY: {0}|\n", text);
                                else if (j == 5)
                                    sw.WriteLine("      |CustomerID: {0}|\n", text);
                                else if (j == 6)
                                    sw.WriteLine("      |Line Total: {0}|\n", text);
                            }
                        }
                        sw.WriteLine("\n\n");
                        sw.WriteLine($"  Subtotal: {textSubtotal.Text}      Tax: {textTax.Text}      Total: {textTotal.Text}");
                    }
                }
            }
            catch (FileNotFoundException x)
            {
                MessageBox.Show($"I could not find the file \"{x.FileName}\" :/");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong...");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void FillBookComboBox()
        {
            try
            {
                // Connecting to DB and getting all the information about the books from there
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Book_T ORDER BY BookID ASC", con);
                con.Open();
                BookID = new ArrayList();
                adapt.Fill(bookSet, "Book_T");
                for (int i = 0; i < bookSet.Tables[0].Rows.Count; i++)
                {
                    comboBox.Items.Add(bookSet.Tables[0].Rows[i]["Title"].ToString());
                    BookID.Add(bookSet.Tables[0].Rows[i]["BookID"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillCustomerComboBox()
        {
            try
            {
                // Connecting to DB and getting all the information about the customers from there
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Customer_T ORDER BY CustomerID ASC", con);
                con.Open();
                CustID = new ArrayList();
                adapt.Fill(customerSet, "Customer_T");
                for (int i = 0; i < customerSet.Tables[0].Rows.Count; i++)
                {
                    comboBox1.Items.Add(customerSet.Tables[0].Rows[i]["FirstName"].ToString() + " " + customerSet.Tables[0].Rows[i]["LastName"].ToString());
                    CustID.Add(customerSet.Tables[0].Rows[i]["CustomerID"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) //Changing textBox values based on chosen book title in comboBox
        {
            textAuthor.Text = bookSet.Tables[0].Rows[comboBox.SelectedIndex]["Author"].ToString();
            textISBN.Text = bookSet.Tables[0].Rows[comboBox.SelectedIndex]["ISBN"].ToString();
            textPrice.Text = "$" + bookSet.Tables[0].Rows[comboBox.SelectedIndex]["Price"].ToString();
        }

        public void buttonAddTitle_Click_1(object sender, EventArgs e) //Everything after button click
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the book from the list");
                comboBox.Focus();
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select the customer from the list");
                comboBox1.Focus();
            }

            bool result = int.TryParse(textQuantity.Text, out Quantity);
            if (!result)
            {
                if (comboBox.SelectedItem == null)
                    comboBox.Focus();
                else
                {
                    MessageBox.Show("Make sure to have valid inputs");
                    textQuantity.Focus();
                }
            }
            else if (Quantity <= 0) //Quantity cannot be less than or equal to 0
            {
                MessageBox.Show("Enter a valid number");
                textQuantity.Focus(); //Focus to the quantity textBox
            }
            else
            {
                for (int i = 0; i < comboBox.Items.Count; i++)
                {
                    if (comboBox.SelectedIndex == i)
                    {
                        string selectedTitle = bookSet.Tables[0].Rows[comboBox.SelectedIndex]["Title"].ToString();
                        int selectedCustID = Convert.ToInt32(CustID[comboBox1.SelectedIndex]);
                        string selectedCustName = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["FirstName"].ToString() + " " + customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["LastName"].ToString();
                        int selectedBookID = Convert.ToInt32(BookID[comboBox.SelectedIndex]);

                        int price = int.Parse(bookSet.Tables[0].Rows[comboBox.SelectedIndex]["Price"].ToString()); //Converting without $ sign in front -> or unhandled exception would happen
                        int lineTotal = Quantity * price;
                        string[] row = new string[] { selectedBookID.ToString(), selectedTitle, textPrice.Text, Quantity.ToString(), selectedCustName, selectedCustID.ToString(), "$" + lineTotal.ToString() }; //An array of columns 
                        

                        subTotal += Quantity * price; //Calculating subTotal value
                        textSubtotal.Text = string.Format("$" + "{0}", subTotal); //Assigning calculated subTotal value to textBox
                        textTax.Text = string.Format("$" + "{0}", (subTotal / 100)); //Assigning calculated Tax value to textBox
                        textTotal.Text = string.Format("$" + "{0}", (subTotal + (subTotal / 100))); //Assigning calculated Total value to textBox
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Maybe you should select a book first :)");
            }
            else if (subTotal == 0)
            {
                MessageBox.Show($"I think you forgot to click on the \"Add Title\" button");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //Clearing every order
                    dataGridView1.Rows.Clear();
                    textPrice.Clear();
                    textAuthor.Clear();
                    textISBN.Clear();
                    textSubtotal.Clear();
                    textTax.Clear();
                    textTotal.Clear();
                    textQuantity.Clear();

                    MessageBox.Show("Your order has been cancelled.");
                }
                else if (dialogResult == DialogResult.No) { }
            }
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null) //If no book was selected from comboBox
            {
                MessageBox.Show("Please select the book in combobox"); //the user will be asked to select one
                comboBox.Focus();
            }
            if (comboBox1.SelectedItem == null) //If no customer was selected from comboBox
            {
                MessageBox.Show("Please select the customer in combobox"); //the user will be asked to select one
                comboBox.Focus();
            }
            else if (subTotal == 0) //also if the user forgot to add title
            {
                MessageBox.Show("Click on the \"Add Title\" button"); //they will be asked to add title
                comboBox.Focus();
            }
            else if (comboBox.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Please confirm your order", "Confirm your order", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    int CustID = 0;
                    int Subtotal = 0;
                    int Tax = 0;
                    int Total = 0;
                    int Qty = 0;
                    int BookID = 0;
                    int latestOrderID = 0;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        CustID = Convert.ToInt32(row.Cells["myCustomerID"].Value);
                        int price = int.Parse(bookSet.Tables[0].Rows[comboBox.SelectedIndex]["Price"].ToString());
                        Subtotal = Convert.ToInt32(row.Cells["myQTY"].Value) * price;
                        Tax = Subtotal / 100;
                        Total = Subtotal + Tax;
                        BookID = Convert.ToInt32(row.Cells["myBookID"].Value);
                        Qty = Convert.ToInt32(row.Cells["myQTY"].Value);

                        OrderTable(CustID, Subtotal.ToString(), Tax.ToString(), Total.ToString());
                        latestOrderID = LatestOrderID();
                        OrderDetailsTable(latestOrderID, Qty.ToString(), Subtotal.ToString());
                        
                    }
                    FileWriter(); //Adding order summary to a .txt file
                    MessageBox.Show("Successfully ordered" + Environment.NewLine + "See order in order.txt file");
                }
            }
        }

        private int LatestOrderID()
        {
            int id = 0;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter da = new SqlDataAdapter("SELECT ORDERID FROM Order_T;", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Order_T");
                id = Convert.ToInt32(ds.Tables[0].Rows[0]["ORDERID"].ToString());
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return id;
        }

        private void OrderTable(int custID, string subtotal, string tax, string total)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Order_T(CustomerID, Subtotal, Tax, Total, OrderDate) VALUES 
                                           ('" + custID + @"', '" + subtotal + @"', '" + tax + @"', 
                                            '" + total + @"', '" + DateTime.Now.ToString("yyyy-MM-dd") + @"')", con);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read()) { }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderDetailsTable(int orderID, string qty, string linestotal)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO OrderDetail_T(OrderID, Quantity, LinesTotal) VALUES 
                                           ('" + orderID + @"', '" + qty + @"', '" + linestotal + @"')", con);
                con.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read()) { }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void castButton_Click(object sender, EventArgs e) //To move to customer "page"
        {
            CustomerForm frm2 = new CustomerForm();
            frm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookForm frm3 = new BookForm();
            frm3.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm store = new MenuForm();
            store.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textQuantity_TextChanged(object sender, EventArgs e) { }
        private void textQuantity_TextChanged_1(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
