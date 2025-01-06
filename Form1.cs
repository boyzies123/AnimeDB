namespace AnimeDB
{
    public partial class Form1 : Form
    {
        private Login login = new Login();
        public Form1()
        {
            InitializeComponent();
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
        }
        public void b_Click(object sender, EventArgs e)
        {
            this.login.Show();
            this.Hide();

        }
    }
}
