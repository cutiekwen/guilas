using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giulias_inventory_system
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        // 04-17-18 11:49 am Added by Abegail Isidro 
        frmClients clients;
        frmHistory history;
        frmProfile profile;
        frmTransaction transactions;
        frmUsers users;
        frmReposrts reports;

        #region "Mouse Hover and Leave"
        private void pbsClients_MouseHover(object sender, EventArgs e)
        {
            pbsClients.Image = Properties.Resources.selected_clients;
        }

        private void pbsClients_MouseLeave(object sender, EventArgs e)
        {
            pbsClients.Image = Properties.Resources.original_clients;
        }

        private void pbsTransaction_MouseHover(object sender, EventArgs e)
        {
            pbsTransaction.Image = Properties.Resources.selected_transaction;
        }

        private void pbsTransaction_MouseLeave(object sender, EventArgs e)
        {
            pbsTransaction.Image = Properties.Resources.original_transaction;
        }

        private void pbsProfile_MouseHover(object sender, EventArgs e)
        {
            pbsProfile.Image = Properties.Resources.selected_profile;
        }

        private void pbsProfile_MouseLeave(object sender, EventArgs e)
        {
            pbsProfile.Image = Properties.Resources.original_profile;
        }

        private void pbsReports_MouseHover(object sender, EventArgs e)
        {
            pbsReports.Image = Properties.Resources.selected_reports;
        }

        private void pbsReports_MouseLeave(object sender, EventArgs e)
        {
            pbsReports.Image = Properties.Resources.original_reports;
        }

        private void pbsHistory_MouseHover(object sender, EventArgs e)
        {
            pbsHistory.Image = Properties.Resources.selected_history;
        }

        private void pbsHistory_MouseLeave(object sender, EventArgs e)
        {
            pbsHistory.Image = Properties.Resources.original_history;
        }

        private void pbsUsers_MouseHover(object sender, EventArgs e)
        {
            pbsUsers.Image = Properties.Resources.selected_users;
        }

        private void pbsUsers_MouseLeave(object sender, EventArgs e)
        {
            pbsUsers.Image = Properties.Resources.original_users;
        }
#endregion
        #region "Main form Clicks"
        private void pbsClients_Click(object sender, EventArgs e)
        {
            this.Hide();
            clients = new frmClients();
            clients.ShowDialog();

        }

        private void pbsTransaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            transactions = new frmTransaction();
            transactions.ShowDialog();
        }

        private void pbsProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            profile = new frmProfile();
            profile.ShowDialog();
        }

        private void pbsReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            reports = new frmReposrts();
            reports.ShowDialog();
        }

        private void pbsHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            history = new frmHistory();
            history.ShowDialog();
        }

        private void pbsUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            users = new frmUsers();
            users.ShowDialog();
        }
        #endregion
    }
}
