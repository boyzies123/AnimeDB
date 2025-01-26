using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeDB
{
    public partial class MediaDetails : Form
    {
        private string url;
        private HttpClient client = new HttpClient();
        public MediaDetails(string url)
        {
            this.url = url;
            InitializeComponent();
        }

        private async void MediaDetails_Load(object sender, EventArgs e)
        {
            Image.Image = await LoadImageFromUrl(url);
        }

        // Function to load image from URL
        private async Task<System.Drawing.Image> LoadImageFromUrl(string url)
        {
            var imageBytes = await client.GetByteArrayAsync(url);

            // Create an image from the byte array and return it
            using (var stream = new MemoryStream(imageBytes))
            {
                return System.Drawing.Image.FromStream(stream);
            }

        }
    }
}
