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
        private Home home;

        private int currentPage = 1;
        private AnimeList animeList;
        private HttpClient client = new HttpClient();
        private List<String> urls = new List <String>();
        public MediaDetails(string urlOne, string urlTwo, string urlThree, string urlFour, string urlFive, string urlSix, Home home, AnimeList animeList)
        {
    
            InitializeComponent();
            this.home = home;
            this.animeList = animeList;
            this.urls.AddRange(new string [] {urlOne, urlTwo, urlThree, urlFour, urlFive, urlSix });
        }

        private async void MediaDetails_Load(object sender, EventArgs e)
        {
            //Image.Image = await LoadImageFromUrl(urlOne);
            //ImageTopMid.Image = await LoadImageFromUrl(urlTwo);
            //ImageTopRight.Image = await LoadImageFromUrl(urlThree);
            //ImageBottomLeft.Image = await LoadImageFromUrl(urlFour);
            //ImageBottomMid.Image = await LoadImageFromUrl(urlFive);
            //ImageBottomRight.Image = await LoadImageFromUrl(urlSix);
            Image.Image = await LoadImageFromUrl(this.urls[0]);
            ImageTopMid.Image = await LoadImageFromUrl(this.urls[1]);
            ImageTopRight.Image = await LoadImageFromUrl(this.urls[2]);
            ImageBottomLeft.Image = await LoadImageFromUrl(this.urls[3]);
            ImageBottomMid.Image = await LoadImageFromUrl(this.urls[4]);
            ImageBottomRight.Image = await LoadImageFromUrl(this.urls[5]);
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Hide();
        }

        private void pageOneButton_Click(object sender, EventArgs e)
        {
            
            if (this.currentPage != 1)
            {
                for (int i = 0; i < 6; i++)
                {
                    urls[i] = animeList.data[i].images.jpg.image_url;
                  
                }
                //this.urlOne = animeList.data[0].images.jpg.image_url;
                //this.urlTwo = animeList.data[1].images.jpg.image_url;
                //this.urlThree = animeList.data[2].images.jpg.image_url;
                //this.urlFour = animeList.data[3].images.jpg.image_url;
                //this.urlFive = animeList.data[4].images.jpg.image_url;
                //this.urlSix = animeList.data[5].images.jpg.image_url;
                this.currentPage = 1;
                MediaDetails_Load(sender, e);
            }
        }

        private void pageTwoButton_Click(object sender, EventArgs e)
        {
            if (this.currentPage != 2)
            {
                for (int i = 0; i < 6; i++)
                {
                    urls[i] = animeList.data[(2 * 3) + i].images.jpg.image_url;


                }
                //this.urlOne = animeList.data[6].images.jpg.image_url;
                //this.urlTwo = animeList.data[7].images.jpg.image_url;
                //this.urlThree = animeList.data[8].images.jpg.image_url;
                //this.urlFour = animeList.data[9].images.jpg.image_url;
                //this.urlFive = animeList.data[10].images.jpg.image_url;
                //this.urlSix = animeList.data[11].images.jpg.image_url;
                this.currentPage = 2;
                MediaDetails_Load(sender, e);
            }
        }
    }
}
