using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeDB
{
    public partial class Home : Form
    {
        private SqlConnection sqlConnection;
        private String username;
        public Home(String username)
        {
            this.username = username;
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
            string query = "SELECT * FROM UserAnime WHERE username = '" + username + "'";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Label l = new Label();
                    l.Text = (string)row["AnimeName"];
                    this.Controls.Add(l);
                }
            }
            catch
            {

            }
        }
    }
}
