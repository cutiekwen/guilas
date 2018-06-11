using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //needed import to connect to the mysql database

namespace giulias_inventory_system
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        // 04-17-18 11:49 am Added by Abegail Isidro 
        clsConnection sc = new clsConnection(); // Calling the Connection class    
        MySqlConnection vDBConn = new MySqlConnection(); // Calling the Sql Connection method
        DataTable dTable; //Initializing Datatable
        frmClientConfiguration cc = new frmClientConfiguration();   //Calls the client configuration form to add or update costumers
        frmHome home = new frmHome();
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }
    }
}
