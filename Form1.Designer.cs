namespace AnimeDB
{
    // See https://aka.ms/new-console-template for more information
    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Text.Json;
    using System.Xml.Linq;


    public class Anime
    {
        public string title_japanese { get; set; }
        public int userRating { get; set; }
        //public int year { get; set; }
        public Images images { get; set; }
    }
    public class AnimeList
    {
        public List<Anime> data { get; set; }
    }
    public class Images
    {
        public ImageUrl jpg { get; set; }
    }
    public class ImageUrl
    {
        public string image_url { get; set; }
        public string small_image_url { get; set; }
        public string large_image_url { get; set; }
    }
        public class AnimeDatabase
        {
            public async Task<AnimeList?> findAnime(string mediaName)
            {
            
                string apiUrl = "https://api.jikan.moe/v4/anime/1";
                apiUrl = "https://api.jikan.moe/v4/anime?q=" + mediaName;
                Debug.WriteLine(apiUrl);
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    Console.WriteLine(response);
                    if (response.IsSuccessStatusCode)
                    {
                        string name = await response.Content.ReadAsStringAsync();
                        Debug.WriteLine(name);
                        AnimeList? anime = JsonSerializer.Deserialize<AnimeList>(name);
                    Debug.WriteLine(anime.data[0].title_japanese);
                    return anime;
                    }
                    else
                    {
                        Debug.WriteLine("Internal server Error");
                    }
                }
                return null;

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
                label1 = new Label();
                SuspendLayout();
                // 
                // label1
                // 
                label1.AutoSize = true;
                label1.Location = new Point(42, 53);
                label1.Name = "label1";
                label1.Size = new Size(0, 25);
                label1.TabIndex = 3;
                label1.Click += label1_Click;
                // 
                // Form1
                // 
                AutoScaleDimensions = new SizeF(10F, 25F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(800, 450);
                Controls.Add(label1);
                Name = "Form1";
                Text = "Form1";
                Load += Form1_Load;
                ResumeLayout(false);
                PerformLayout();
            }

            #endregion
            private Label label1;
        }
    
}
