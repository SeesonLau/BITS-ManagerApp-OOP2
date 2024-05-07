using System.Data;
using System.Data.OleDb;

namespace CpE_262_Project_IV
{
    public partial class AdminManageAccount : UserControl
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public AdminManageAccount()
        {
            InitializeComponent();
            try
            {
                da = new OleDbDataAdapter("SELECT *FROM PassengerAccount", databaseAccess.GetConnection());
                ds = new DataSet();
                databaseAccess.OpenConn();
                da.Fill(ds, "PassengerAccount");
                dgvAccount.DataSource = ds.Tables["PassengerAccount"];
                databaseAccess.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                da = new OleDbDataAdapter("SELECT *FROM PassengerAccount", databaseAccess.GetConnection());
                ds = new DataSet();
                databaseAccess.OpenConn();
                da.Fill(ds, "PassengerAccount");
                dgvAccount.DataSource = ds.Tables["PassengerAccount"];
                databaseAccess.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexRow >= 0 && indexRow < dgvAccount.Rows.Count)
                {
                    DataGridViewRow row = dgvAccount.Rows[indexRow];
                    string Ticketing = "UPDATE PassengerAccount SET [UserName] = @username, [PassengerID] = @passengerID, [PassengerType] = @passengertype, [FullName] = @fullname, [Email] = @email, [ContactNumber] = @contactnumber, " +
                        "[PhotoID] = @photoID Where ID = @ID";
                    cmd = new OleDbCommand(Ticketing, databaseAccess.GetConnection());
                    cmd.Parameters.AddWithValue("@username", txtboxUsername.Text);
                    cmd.Parameters.AddWithValue("@passengerID", txtboxPassengerID.Text);
                    cmd.Parameters.AddWithValue("@passengertype", cbPassengertype.Text);
                    cmd.Parameters.AddWithValue("@fullname", txtboxFullname.Text);
                    cmd.Parameters.AddWithValue("@email", txtboxEmail.Text);
                    cmd.Parameters.AddWithValue("@contactnumber", txtboxContactNumber.Text);
                    cmd.Parameters.AddWithValue("@photoID", pbPhotoID.Image);
                    cmd.Parameters.AddWithValue("@ID", row.Cells["ID"].Value);
                    databaseAccess.OpenConn();
                    cmd.ExecuteNonQuery();
                    databaseAccess.CloseConn();
                    btnLoad_Click(sender, e);
                    row.Cells["UserName"].Value = txtboxUsername.Text;
                    row.Cells["PassengerID"].Value = txtboxPassengerID.Text;
                    row.Cells["PassengerType"].Value = cbPassengertype.Text;
                    row.Cells["FullName"].Value = txtboxFullname.Text;
                    row.Cells["Email"].Value = txtboxEmail.Text;
                    row.Cells["ContactNumber"].Value = txtboxContactNumber.Text;
                    row.Cells["PhotoID"].Value = pbPhotoID.Image;
                    MessageBox.Show("Data updated successfully! LEGIT");
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Data updated successfully!");
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string account = "Delete from PassengerAccount where ID = @id";
                cmd = new OleDbCommand(account, databaseAccess.GetConnection());
                cmd.Parameters.AddWithValue("@id", dgvAccount.CurrentRow.Cells[0].Value);
                databaseAccess.OpenConn();
                cmd.ExecuteNonQuery();
                databaseAccess.CloseConn();

                btnLoad_Click(sender, e);
                MessageBox.Show("Data deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e){}
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = dgvAccount.Rows[indexRow];

                    txtboxUsername.Text = row.Cells["UserName"].Value.ToString();
                    txtboxPassengerID.Text = row.Cells["PassengerID"].Value.ToString();
                    cbPassengertype.Text = row.Cells["PassengerType"].Value?.ToString();
                    txtboxFullname.Text = row.Cells["FullName"].Value.ToString();
                    txtboxEmail.Text = row.Cells["Email"].Value.ToString();
                    txtboxContactNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                    byte[] imageData = (byte[])row.Cells["PhotoID"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pbPhotoID.Image = Image.FromStream(ms);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
