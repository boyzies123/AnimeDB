namespace AnimeDB
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonSubmit;


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
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(150, 151);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(124, 25);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email Address";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(280, 151);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(213, 31);
            textBoxEmail.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(150, 193);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(91, 25);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(280, 193);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(213, 31);
            textBoxUsername.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.Location = new Point(150, 233);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 23);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            labelPassword.Click += labelPassword_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(280, 238);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(213, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(335, 294);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(88, 32);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.Click += ButtonSubmit_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelUsername);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonSubmit);
            Name = "CreateAccount";
            Text = "CreateAccount";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            String email = textBoxEmail.Text;
            String query = "INSERT INTO Users VALUES(" + username + ", " + password + ", " + email + ")";
            throw new NotImplementedException();
        }

        #endregion

    }
}