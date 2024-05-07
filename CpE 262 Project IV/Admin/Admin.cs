namespace CpE_262_Project_IV
{
    public partial class Admin : Form
    {
        private MethodPanel dragpanel = new MethodPanel();
        public Admin()
        {
            InitializeComponent();
            dragpanel.Attach(panel1, this);
            adminManageAccount1.Hide();
            adminManageTicketing1.Hide();
            adminStatistics1.Hide();
            panelAbout.Hide();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flpMenuContainer.Height += 10;
                if (flpMenuContainer.Height >= 146)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flpMenuContainer.Height -= 10;
                if (flpMenuContainer.Height <= 50)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e) { }
        private void btnUserSelection_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private void btnDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Driver().Show();
        }
        private void btnPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F3PassengerLogin().Show();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSidebar.Width -= 15;
                if (flpSidebar.Width <= 50)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                flpSidebar.Width += 15;
                if (flpSidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        private async void pbHam_Click(object sender, EventArgs e)
        {
            if (adminManageTicketing1.Visible)
            {
                adminManageTicketing1.Hide();
                sidebarTransition.Start();
                await Task.Delay(500);
                adminManageTicketing1.Show();
            }
            else if (adminManageAccount1.Visible)
            {
                adminManageAccount1.Hide();
                sidebarTransition.Start();
                await Task.Delay(500);
                adminManageAccount1.Show();
            }
            else if (adminStatistics1.Visible)
            {
                adminStatistics1.Hide();
                sidebarTransition.Start();
                await Task.Delay(500);
                adminStatistics1.Show();
            }
        }
        private void rbHome_CheckedChanged(object sender, EventArgs e){}
        private void userControl31_Load(object sender, EventArgs e){}
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
        private void btnManageTicketing_Click(object sender, EventArgs e)
        {
            panelAbout.Hide();
            adminStatistics1.Hide();
            adminManageAccount1.Hide();
            adminManageTicketing1.Show();
        }
        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            panelAbout.Hide();
            adminManageTicketing1.Hide();
            adminStatistics1.Hide();
            adminManageAccount1.Show();
        }
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            panelAbout.Hide();
            adminManageTicketing1.Hide();
            adminManageAccount1.Hide();
            adminStatistics1.Show();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            adminManageTicketing1.Hide();
            adminManageAccount1.Hide();
            adminStatistics1.Hide();
            panelAbout.Show();
        }
        private void userControl21_Load(object sender, EventArgs e){}
        private void btnHome_Click(object sender, EventArgs e)
        {
            panelAbout.Hide();
            adminManageTicketing1.Hide();
            adminManageAccount1.Hide();
            adminStatistics1.Hide();
        }
        private void label5_Click(object sender, EventArgs e){}
    }
}
