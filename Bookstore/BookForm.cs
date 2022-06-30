using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Lana
/// BookForm class with all the necessary methods/functions to implement bookstore
/// </summary> 
/// 

namespace Assignment1
{
    public partial class BookForm : Form
    {
        private readonly DataSet bookSet = new DataSet();
        private ArrayList ID { get; set; }
        private bool buttonNewBookclick = new bool();
        
        public BookForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Fillcombobox();
        }
       
        public void Fillcombobox()
        {
            try
            {
                // Connecting to DB and getting all the information about the books from there
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Book_T ORDER BY BookID ASC", con);
                con.Open();
                ID = new ArrayList();
                adapt.Fill(bookSet, "Book_T");
                for (int i = 0; i < bookSet.Tables[0].Rows.Count; i++)
                {
                    comboBox1.Items.Add(bookSet.Tables[0].Rows[i]["Title"].ToString());
                    ID.Add(bookSet.Tables[0].Rows[i]["BookID"].ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textTitle.Text = bookSet.Tables[0].Rows[comboBox1.SelectedIndex]["Title"].ToString();
            textAuthor.Text = bookSet.Tables[0].Rows[comboBox1.SelectedIndex]["Author"].ToString();
            textISBN.Text = bookSet.Tables[0].Rows[comboBox1.SelectedIndex]["ISBN"].ToString();
            textPrice.Text = bookSet.Tables[0].Rows[comboBox1.SelectedIndex]["Price"].ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm store = new MenuForm();
            store.Show();
        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            // Clearing the fields of the textboxes
            textTitle.Clear();
            textAuthor.Clear();
            textISBN.Clear();
            textPrice.Clear();

            comboBox1.Enabled = false;
            buttonNewBookclick = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // case 1: edit a selected book
            if (!(comboBox1.SelectedItem == null) && buttonNewBookclick == false) 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                    
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Book_T where Title=@Title", con);
                    cmd.Parameters.AddWithValue("@Title", textTitle.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    if (reader != null && reader.HasRows)
                        MessageBox.Show("The book with the same title already exists, check combobox");
                    else
                    {
                        EditorcreateBook(textTitle.Text, textAuthor.Text, textISBN.Text, textPrice.Text);
                        MessageBox.Show("Successfully saved a new book");
                        buttonNewBookclick = false;
                        comboBox1.Enabled = true;
                    }

                    con.Close();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            // case 2: create a new book
            else if (buttonNewBookclick == true) 
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Book_T where Title=@Title", con);
                    cmd.Parameters.AddWithValue("@Title", textTitle.Text);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader != null && reader.HasRows)
                        MessageBox.Show("The book with the same title already exists, check combobox");
                    else
                    {
                        EditorcreateBook(textTitle.Text, textAuthor.Text, textISBN.Text, textPrice.Text);
                        MessageBox.Show("Successfully saved a new book");
                        buttonNewBookclick = false;
                        comboBox1.Enabled = true;
                    }

                    con.Close();
                }
                else if (dialogResult == DialogResult.No) { }
            }
            // case 3
            else if (comboBox1.SelectedItem == null)
                MessageBox.Show("Click New Book button or choose a book from combobox");
            // case 4
            else
                MessageBox.Show("Something went wrong :/");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // The database should be checked to see if anything of the text boxes 
                // had been changed and repopulate the combo box and textboxes accordingly.
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Book_T ORDER BY BookID ASC", con);
                con.Open();
                DataSet ds = new DataSet();
                ID = new ArrayList();
                adapt.Fill(ds, "Book_T");
                int SelectedIndexTemp = comboBox1.SelectedIndex;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Select book from the list or click new book button");
                    comboBox1.Enabled = true;
                }
                else
                {
                    // To see if some changes have happened
                    if (!(string.Compare(ds.Tables[0].Rows[0]["Title"].ToString(), textTitle.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Author"].ToString(), textAuthor.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["ISBN"].ToString(), textISBN.Text) == 0 &&
                    string.Compare(ds.Tables[0].Rows[0]["Price"].ToString(), textPrice.ToString()) == 0))
                    {
                        // Clearing and repopulating
                        comboBox1.Items.Clear();
                        bookSet.Clear();
                        ID.Clear();
                        Fillcombobox();

                        textTitle.Text = bookSet.Tables[0].Rows[SelectedIndexTemp]["Title"].ToString();
                        textAuthor.Text = bookSet.Tables[0].Rows[SelectedIndexTemp]["Author"].ToString();
                        textISBN.Text = bookSet.Tables[0].Rows[SelectedIndexTemp]["ISBN"].ToString();
                        textPrice.Text = bookSet.Tables[0].Rows[SelectedIndexTemp]["Price"].ToString();
                        comboBox1.SelectedIndex = SelectedIndexTemp;
                        
                        textTitle.Clear();
                        textAuthor.Clear();
                        textISBN.Clear();
                        textPrice.Clear();
                        MessageBox.Show("Cancelled");
                        comboBox1.Text = "Edit an Existing Book";
                    }
                    else
                        MessageBox.Show("Please make sure to click correct buttons and follow directions");
                }
                    con.Close();
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void EditorcreateBook(string Title, string Author, string ISBN, string Price)
        {
            // call the sqlcommand update and update the record that exists there
            // validation that changes have been made to the current book
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DKIEF04\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"INSERT INTO Book_T(Title, Author, ISBN, Price) VALUES ('" + Title + @"', '" + Author + @"', '" + ISBN + @"', '" + Price + @"')", con);
            con.Open();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read()) { }
            con.Close();
        }
    }
}
