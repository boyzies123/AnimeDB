using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace AnimeDB
{
    public partial class Login : Form
    {
        private SqlConnection sqlConnection;
        private string inputUsername;
        private string inputPassword;
        public Login()
        {
            InitializeComponent();
            try
            {
                sqlConnection = new SqlConnection(@"Data Source=DESKTOP-4PPVB83;Initial Catalog=AnimeDB;Integrated Security=True");
                sqlConnection.Open(); // Open the connection immediately after initialization
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
  
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Invalid operation occurred: " + ex.Message);
            
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Login button
        private void button1_Click(object sender, EventArgs e)
        {
            

            inputUsername = textBox1.Text;
            inputPassword = textBox2.Text;
            string query = "SELECT * FROM Users WHERE username = '" + inputUsername + "' AND password = '" + inputPassword + "'";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // next screen
                    Home home = new Home(inputUsername);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    Label label3 = getLabel3();
                    label3.Show();
                    //warning
                }
            }
            catch (SqlException ex)
            {
                // Handle SQL exceptions
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Handle invalid operation exceptions
                MessageBox.Show("An invalid operation occurred: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Handle argument exceptions
                MessageBox.Show("An error occurred with the provided arguments: " + ex.Message);
            }
            catch (DataException ex)
            {
                // Handle data exceptions
                MessageBox.Show("A data error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            {

            }
        }
 
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
