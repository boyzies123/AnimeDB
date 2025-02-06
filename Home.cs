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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
namespace AnimeDB
{
    public partial class Home : Form
    {
        private SqlConnection sqlConnection;
        private String username;
        private AnimeDatabase animeDatabase;
        public Home(String username)
        {
            this.username = username;
            this.animeDatabase = new AnimeDatabase();
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

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private async void buttonSubmit_ClickAsync(object sender, EventArgs e)
        {
            AnimeList anime = await animeDatabase.findAnime(SearchBar.Text);
            Debug.WriteLine(SearchBar.Text + "," + "test" + anime.data[0].images + "," + anime.data[0].images.jpg);
            MediaDetails mediaDetails = new MediaDetails(anime.data[0].images.jpg.image_url, anime.data[1].images.jpg.image_url, anime.data[2].images.jpg.image_url, anime.data[3].images.jpg.image_url, anime.data[4].images.jpg.image_url, anime.data[5].images.jpg.image_url, this, anime);
            mediaDetails.Show();
            this.Hide();
        }
    }
}
