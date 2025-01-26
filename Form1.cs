namespace AnimeDB
{
    //Program will run this form that displays entrypoint screen
    public partial class Form1 : Form
    {
        private Login login = new Login();
        private CreateAccount createAccount = new CreateAccount();
        public Form1()
        {

            initializeCustomComponent();


        }
        public void initializeCustomComponent()
        {
            Label titleLabel = new Label();
            titleLabel.Location = new System.Drawing.Point(50, 50);
            titleLabel.Size = new System.Drawing.Size(200, 30);
            titleLabel.Text = "Welcome to AnimeDB";
            this.Controls.Add(titleLabel);
            Button b = new Button();
            b.Location = new Point(50, 100);
            b.Size = new Size(200, 60);
            b.Text = "Login";
            this.Controls.Add(b);
            b.Click += b_Click;
            Button createAccount = new Button();
            createAccount.Location = new Point(50, 200);
            createAccount.Size = new Size(200, 60);
            createAccount.Text = "Create Account";
            this.Controls.Add(createAccount);
            createAccount.Click += createAccount_Click;

        }
        public void b_Click(object sender, EventArgs e)
        {
            this.login.Show();
            this.Hide();

        }
        public void createAccount_Click(object sender, EventArgs e)
        {
            this.createAccount.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
