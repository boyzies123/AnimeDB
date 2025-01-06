namespace AnimeDB
{
    // See https://aka.ms/new-console-template for more information
    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Xml.Linq;

    public class Anime
    {
        public string title { get; set; }
        public int rating { get; set; }
        public int year { get; set; }

    }

    public class AnimeDatabase
    {
        public async Task findAnime()
        {
            string apiUrl = "https://api.jikan.moe/v4/anime/1";
            apiUrl = "https://api.jikan.moe/v4/anime?q=Demon Slayer";
            Console.WriteLine(apiUrl);
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    string name = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(name);
                    Anime? anime = JsonSerializer.Deserialize<Anime>(name);
                    Console.WriteLine(anime?.title);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }

        }


    }
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
