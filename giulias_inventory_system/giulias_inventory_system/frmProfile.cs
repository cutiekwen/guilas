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
    public partial class frmProfile : Form
    {
        public frmProfile()
        {
            InitializeComponent();
        }
        // 04-17-18 3:00 pm Added by Abegail Isidro 
        clsConnection sc = new clsConnection(); // Calling the Connection class    
        MySqlConnection vDBConn = new MySqlConnection(); // Calling the Sql Connection method
        DataTable dTable; //Initializing Datatable
        frmClientConfiguration cc = new frmClientConfiguration();   //Calls the client configuration form to add or update costumers
        frmHome home = new frmHome();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Clicking the Upload Button
            // added by Abegail Isidro
            // April 17, 2018

            OpenFileDialog ofdPic = new OpenFileDialog();
            ofdPic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofdPic.ShowDialog() == DialogResult.OK)
            {
                pbClientImage.ImageLocation = ofdPic.FileName;

            }
        }
    }
}
