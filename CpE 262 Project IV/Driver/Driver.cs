namespace CpE_262_Project_IV
{
    public partial class Driver : Form
    {
        private MethodPanel dragpanel = new MethodPanel();
        public Driver()
        {
            InitializeComponent();
            dragpanel.Attach(panel1, this);
            dragpanel.Attach(panel2, this);
            dragpanel.Attach(panel3, this);
            dragpanel.Attach(panel4, this);
            driverHome1.Show();
        }

        private void Driver_Load(object sender, EventArgs e) { }
        private void btnHome_Click(object sender, EventArgs e)
        {
            driverHome1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            driverHome1.Hide();
        }

        private void driverSetting1_Load(object sender, EventArgs e){}
    }
}
