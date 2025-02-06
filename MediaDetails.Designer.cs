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
            ImageTopMid = new PictureBox();
            ImageTopRight = new PictureBox();
            ImageBottomLeft = new PictureBox();
            ImageBottomMid = new PictureBox();
            ImageBottomRight = new PictureBox();
            backButton = new Button();
            pageOneButton = new Button();
            pageTwoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageTopMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageTopRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomMid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomRight).BeginInit();
            SuspendLayout();
            // 
            // Image
            // 
            Image.Location = new Point(43, 30);
            Image.Name = "Image";
            Image.Size = new Size(239, 314);
            Image.TabIndex = 0;
            Image.TabStop = false;
            // 
            // ImageTopMid
            // 
            ImageTopMid.Location = new Point(308, 30);
            ImageTopMid.Name = "ImageTopMid";
            ImageTopMid.Size = new Size(239, 314);
            ImageTopMid.TabIndex = 1;
            ImageTopMid.TabStop = false;
            // 
            // ImageTopRight
            // 
            ImageTopRight.Location = new Point(567, 30);
            ImageTopRight.Name = "ImageTopRight";
            ImageTopRight.Size = new Size(221, 314);
            ImageTopRight.TabIndex = 2;
            ImageTopRight.TabStop = false;
            // 
            // ImageBottomLeft
            // 
            ImageBottomLeft.Location = new Point(43, 368);
            ImageBottomLeft.Name = "ImageBottomLeft";
            ImageBottomLeft.Size = new Size(239, 314);
            ImageBottomLeft.TabIndex = 3;
            ImageBottomLeft.TabStop = false;
            // 
            // ImageBottomMid
            // 
            ImageBottomMid.Location = new Point(308, 368);
            ImageBottomMid.Name = "ImageBottomMid";
            ImageBottomMid.Size = new Size(239, 314);
            ImageBottomMid.TabIndex = 4;
            ImageBottomMid.TabStop = false;
            // 
            // ImageBottomRight
            // 
            ImageBottomRight.Location = new Point(567, 368);
            ImageBottomRight.Name = "ImageBottomRight";
            ImageBottomRight.Size = new Size(221, 314);
            ImageBottomRight.TabIndex = 5;
            ImageBottomRight.TabStop = false;
            // 
            // backButton
            // 
            backButton.Location = new Point(55, 701);
            backButton.Name = "backButton";
            backButton.Size = new Size(96, 36);
            backButton.TabIndex = 6;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // pageOneButton
            // 
            pageOneButton.Location = new Point(215, 701);
            pageOneButton.Name = "pageOneButton";
            pageOneButton.Size = new Size(40, 36);
            pageOneButton.TabIndex = 7;
            pageOneButton.Text = "1";
            pageOneButton.UseVisualStyleBackColor = true;
            pageOneButton.Click += pageOneButton_Click;
            // 
            // pageTwoButton
            // 
            pageTwoButton.Location = new Point(272, 701);
            pageTwoButton.Name = "pageTwoButton";
            pageTwoButton.Size = new Size(40, 36);
            pageTwoButton.TabIndex = 8;
            pageTwoButton.Text = "2";
            pageTwoButton.UseVisualStyleBackColor = true;
            pageTwoButton.Click += pageTwoButton_Click;
            // 
            // MediaDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 749);
            Controls.Add(pageTwoButton);
            Controls.Add(pageOneButton);
            Controls.Add(backButton);
            Controls.Add(ImageBottomRight);
            Controls.Add(ImageBottomMid);
            Controls.Add(ImageBottomLeft);
            Controls.Add(ImageTopRight);
            Controls.Add(ImageTopMid);
            Controls.Add(Image);
            Name = "MediaDetails";
            Text = "MediaDetails";
            Load += MediaDetails_Load;
            ((System.ComponentModel.ISupportInitialize)Image).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageTopMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageTopRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomLeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomMid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBottomRight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Image;
        private PictureBox ImageTopMid;
        private PictureBox ImageTopRight;
        private PictureBox ImageBottomLeft;
        private PictureBox ImageBottomMid;
        private PictureBox ImageBottomRight;
        private Button backButton;
        private Button pageOneButton;
        private Button pageTwoButton;
    }
}