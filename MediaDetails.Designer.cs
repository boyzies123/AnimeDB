namespace AnimeDB
{
    partial class MediaDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Image = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            SuspendLayout();
            // 
            // Image
            // 
            Image.Location = new Point(32, 52);
            Image.Name = "Image";
            Image.Size = new Size(249, 291);
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // MediaDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Image);
            Name = "MediaDetails";
            Text = "MediaDetails";
            Load += MediaDetails_Load;
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Image;
    }
}