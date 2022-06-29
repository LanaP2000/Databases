using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

/// <summary>
/// Lana Pantskalashvili
/// 823358842
/// CustomerForm class with all the necessary methods/functions to implement customer page
/// </summary> 
/// 

namespace Assignment1
{
    public partial class CustomerForm : Form
    {
        private readonly DataSet customerSet = new DataSet();
        private ArrayList ID { get; set; }

        private bool buttonNewCustomerclick = new bool();
        readonly string castName = "^(?<firstchar>[A-Za-z])((?<alphachars>[A-Za-z])|(?<specialchars>[A-Za-z]['-][A-Za-z])|(?<spaces> [A-Za-z]))*$"; // Regex to ensure names, city, address, and state are proper
        readonly string castZip = @"^[-+]?[0-9]*\.?[0-9]+$"; // Regex to ensure zip code and phone number are proper

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            this.Hide();
            MenuForm store = new MenuForm();
            store.Show();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e) // Data invariant
        {
            if ((textFirstname.Text == "") || (textLastname.Text == "") || (textAddress.Text == "") || (textCity.Text == "") 
                || (textState.Text == "") || (textZip.Text == "") || (textPhone.Text == "") || (textEmail.Text == ""))
            {
                MessageBox.Show("Please, do not leave any box blank!");
            }
            else
            {
                if (!Regex.IsMatch(textFirstname.Text, castName))
                {
                    MessageBox.Show("Please enter your first name");
                    textFirstname.Focus();
                }
                else if (!Regex.IsMatch(textLastname.Text, castName))
                {
                    MessageBox.Show("Please enter your last name");
                    textLastname.Focus();
                }
                else if (textAddress.Text == "") 
                {
                    MessageBox.Show("Please enter your address");
                    textAddress.Focus();
                }
                else if (!Regex.IsMatch(textCity.Text, castName))
                {
                    MessageBox.Show("Please enter your city");
                    textCity.Focus();
                }
                else if (!Regex.IsMatch(textState.Text, castName))
                {
                    MessageBox.Show("Please enter your state");
                    textState.Focus();
                }
                else if (!Regex.IsMatch(textZip.Text, castZip))
                {
                    MessageBox.Show("Please enter your zip code");
                    textZip.Focus();
                }
                else if (!Regex.IsMatch(textPhone.Text, castZip))
                {
                    if (textPhone.Text.Length != 9)
                    {
                        MessageBox.Show("make sure the number of digits is not more than 9(it's Georgia)");
                        textPhone.Focus();
                    }  
                    else
                    {
                        MessageBox.Show("Please enter your phone, ");
                        textPhone.Focus();
                    }   
                }
                else if (!IsValidEmail(textEmail.Text))
                {
                    MessageBox.Show("Please enter your email");
                    textEmail.Focus();
                }
                else
                {
                    // case 1: edit
                    if (!(comboBox1.SelectedItem == null) && buttonNewCustomerclick == false)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");

                            con.Open();
                            SqlCommand cmd = new SqlCommand("select * from Customer_T where FirstName=@FirstName", con);
                            cmd.Parameters.AddWithValue("@FirstName", textFirstname.Text);
                            SqlDataReader reader = cmd.ExecuteReader();

                            con1.Open();
                            SqlCommand cmd1 = new SqlCommand("select * from Customer_T where LastName=@LastName", con1);
                            cmd1.Parameters.AddWithValue("@LastName", textLastname.Text);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader != null && reader.HasRows && reader1 != null && reader1.HasRows)
                            {
                                MessageBox.Show("The Person with the same name and surname already exists, check combobox");
                                comboBox1.Enabled = true;
                                comboBox1.Focus();
                            }
                            else
                            {
                                EditorcreateBook(textFirstname.Text, textLastname.Text, textAddress.Text, textCity.Text, textState.Text, textZip.Text, textPhone.Text, textEmail.Text);
                                buttonNewCustomerclick = false;
                                MessageBox.Show("Added Successfully");
                            }
                            con1.Close();
                            con.Close();
                        }
                        else if (dialogResult == DialogResult.No) { }
                    }
                    // case 2: create
                    else if (buttonNewCustomerclick == true)
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // Investigating whether the exact name and lastname exist in the DB or not
                            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                            SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");

                            con.Open();
                            SqlCommand cmd = new SqlCommand("select * from Customer_T where FirstName=@FirstName", con);
                            cmd.Parameters.AddWithValue("@FirstName", textFirstname.Text);
                            SqlDataReader reader = cmd.ExecuteReader();

                            con1.Open();
                            SqlCommand cmd1 = new SqlCommand("select * from Customer_T where LastName=@LastName", con1);
                            cmd1.Parameters.AddWithValue("@LastName", textLastname.Text);
                            SqlDataReader reader1 = cmd1.ExecuteReader();

                            if (reader != null && reader.HasRows && reader1 != null && reader1.HasRows)
                            {
                                MessageBox.Show("The Person with the same name and surname already exists, check combobox");
                                comboBox1.Enabled = true;
                                comboBox1.Focus();
                            }
                            else
                            {
                                EditorcreateBook(textFirstname.Text, textLastname.Text, textAddress.Text, textCity.Text, textState.Text, textZip.Text, textPhone.Text, textEmail.Text);
                                buttonNewCustomerclick = false;
                                MessageBox.Show("Added Successfully");
                                Custwriter();
                                MessageBox.Show("Customer is written in \"customers.txt\" file, so you can check it.");
                            }
                            con1.Close();
                            con.Close();
                        }
                        else if (dialogResult == DialogResult.No) { }
                    }
                    // case 3
                    else if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Click New button or choose a customer from the combobox");
                        comboBox1.Enabled = true;
                    }
                    // case 4
                    else
                        MessageBox.Show("Something went wrong :/");
                }
            }
        }

        public void Custwriter() // Writing customer information in a file
        {
            try
            {
                string path = Application.StartupPath.ToString() + @"..\..\..\bin\Debug\customers.txt";
                string custInfo = null;
                custInfo += $"{textFirstname.Text}|{textLastname.Text}|{textAddress.Text}|{textCity.Text}|{textState.Text}|{textZip.Text}|{textPhone.Text}|{textEmail.Text}\n"; //| is delimiter in this case
                File.AppendAllText(path, custInfo);
            }
            catch (FileNotFoundException x)
            {
                MessageBox.Show($"I could not find the file \"{x.FileName}\" :/");
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong...");
            }
            catch (Exception y)
            {
                MessageBox.Show(y.ToString());
            }
        }

        private void EditorcreateBook(string Firstname, string Lastname, string Address, string City, string State, string Zip, string Phone, string Email)
        {
            // call the sqlcommand update and update the record that exists there
            // validation that changes have been made to the current book
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"INSERT INTO Customer_T(FirstName, LastName, Addresss, City, States, Zip, Phone, Email) VALUES 
                                           ('" + Firstname + @"', '" + Lastname + @"', '" + Address + @"', '" + City + @"', 
                                            '" + State + @"', '" + Zip + @"', '" + Phone + @"', '" + Email + @"')", con);
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read()) { }
            con.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // The database should be checked to see if anything of the text boxes 
                // had been changed and repopulate the combo box and textboxes accordingly.

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Customer_T ORDER BY CustomerID ASC", con);
                con.Open();
                DataSet ds = new DataSet();
                ID = new ArrayList();
                adapt.Fill(ds, "Customer_T");
                int SelectedIndexTemp = comboBox1.SelectedIndex;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select book from the list or click new book button");
                    comboBox1.Enabled = true;
                }
                else
                {
                    // To see any changes
                    if (!(string.Compare(ds.Tables[0].Rows[0]["FirstName"].ToString(), textFirstname.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["LastName"].ToString(), textLastname.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Addresss"].ToString(), textAddress.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["City"].ToString(), textCity.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["States"].ToString(), textState.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Zip"].ToString(), textZip.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Phone"].ToString(), textPhone.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Email"].ToString(), textEmail.Text) == 0))
                    {
                        // Clearing and repopulating
                        comboBox1.Items.Clear();
                        customerSet.Clear();
                        ID.Clear();
                        FillComboBox();
                        
                        textFirstname.Clear();
                        textLastname.Clear();
                        textAddress.Clear();
                        textCity.Clear();
                        textState.Clear();
                        textZip.Clear();
                        textPhone.Clear();
                        textEmail.Clear();
                        MessageBox.Show("Cancelled");
                        comboBox1.Text = "Edit an Existing Book";
                    }
                    else
                    {
                        comboBox1.Items.Clear();
                        customerSet.Clear();
                        ID.Clear();
                        FillComboBox();
                        
                        textFirstname.Clear();
                        textLastname.Clear();
                        textAddress.Clear();
                        textCity.Clear();
                        textState.Clear();
                        textZip.Clear();
                        textPhone.Clear();
                        textEmail.Clear();
                        MessageBox.Show("Cancelled");
                        comboBox1.Text = "Edit an Existing Book";
                    }  
                }
                con.Close();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textFirstname.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["FirstName"].ToString();
            textLastname.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["LastName"].ToString();
            textAddress.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["Addresss"].ToString();
            textCity.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["City"].ToString();
            textState.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["States"].ToString();
            textZip.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["Zip"].ToString();
            textPhone.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["Phone"].ToString();
            textEmail.Text = customerSet.Tables[0].Rows[comboBox1.SelectedIndex]["Email"].ToString();
        }

        private void FillComboBox()
        {
            try
            {
                // Connecting to DB and getting all the information about the customers from there
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Customer_T ORDER BY CustomerID ASC", con);
                con.Open();
                ID = new ArrayList();
                adapt.Fill(customerSet, "Customer_T");
                for (int i = 0; i < customerSet.Tables[0].Rows.Count; i++)
                {
                    comboBox1.Items.Add(customerSet.Tables[0].Rows[i]["FirstName"].ToString() + " " + customerSet.Tables[0].Rows[i]["LastName"].ToString());
                    ID.Add(customerSet.Tables[0].Rows[i]["CustomerID"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            textFirstname.Clear();
            textLastname.Clear();
            textAddress.Clear();
            textCity.Clear();
            textState.Clear();
            textZip.Clear();
            textPhone.Clear();
            textEmail.Clear();
            comboBox1.Enabled = false;
            textFirstname.Focus();
            buttonNewCustomerclick = true;
        }
    }
}
