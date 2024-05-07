namespace CpE_262_Project_IV
{
    public partial class Passenger : Form
    {
        private MethodPanel dragpanel = new MethodPanel();
        RoundRadioButton roundrb = new RoundRadioButton();
        public Passenger()
        {
            InitializeComponent();
            dragpanel.Attach(panel1, this);
            dragpanel.Attach(panel2, this);
            dragpanel.Attach(panel3, this);
            dragpanel.Attach(panel4, this);
 
            passengerTicket1.Hide();
            passengerHistory1.Hide();
            passengerHome2.Show();
        }
        private void btnTicketing_Click(object sender, EventArgs e)
        {
            passengerHistory1.Hide();
            passengerHome2.Hide();
            passengerTicket1.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            passengerTicket1.Hide();
            passengerHome2.Hide();
            passengerHistory1.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            passengerTicket1.Hide();
            passengerHistory1.Hide();
            passengerHome2.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
