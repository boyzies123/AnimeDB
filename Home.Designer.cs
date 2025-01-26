namespace AnimeDB
{
    partial class Home
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
            label1 = new Label();
            label2 = new Label();
            SearchBar = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 45);
            label1.Name = "label1";
            label1.Size = new Size(296, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome to AnimeDB";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(168, 29);
            label2.TabIndex = 1;
            label2.Text = "Trending Shows";
            label2.Click += label2_Click;
            // 
            // SearchBar
            // 
            SearchBar.BackColor = SystemColors.ButtonFace;
            SearchBar.Location = new Point(243, 136);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(306, 31);
            SearchBar.TabIndex = 2;
            SearchBar.Text = "Search";
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(587, 135);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(88, 32);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Submit";
            buttonSubmit.Click += buttonSubmit_ClickAsync;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSubmit);
            Controls.Add(SearchBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Form2";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox SearchBar;
        private Button buttonSubmit;
    }
}