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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        // 04-17-18 3:00 pm Added by Abegail Isidro 
        clsConnection sc = new clsConnection(); // Calling the Connection class    
        MySqlConnection vDBConn = new MySqlConnection(); // Calling the Sql Connection method
        DataTable dTable; //Initializing Datatable
        frmClientConfiguration cc = new frmClientConfiguration();   //Calls the client configuration form to add or update costumers
        frmHome home = new frmHome();
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            // initializing the forms when loaded
            // added by Abegail Isidro
            // April 17, 2018

            dTable = new DataTable(); //initializing datatable
            sc.OpenConnection(); // accessing the OpenConnection method from the Connection class
            get_users_details(dTable);
            dgvResults.DataSource = dTable; // assigning values to the datagridview
            dTable.Dispose();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clear_values();
        }
        private void get_users_details(DataTable dt)
        {
            // added by Abegail Isidro
            // April 17, 2018
            try
            {
                sc.OpenConnection();
                sc.command = sc.SQLCommand("Select * From users");
                sc.sqlReader = sc.command.ExecuteReader();
                dt.Load(sc.sqlReader);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                sc.CloseConnection();
            }
        }


        public void add_update_user_details(DataTable dt)
        {
            // added by Abegail Isidro
            // April 17, 2018


            string first_name = txtFname.Text;
            string last_name = txtLast.Text;
            string middle_initial = txtMid.Text;
            string birth_date = dtpBirthday.Value.ToString("yyyy,MM,dd");   
            if (radFemale.Checked ==true){
                string gender = radFemale.Text;
            }
            else {
                string gender = radMale.Text;
            }
            string position = this.cmbPosition.Items[this.cmbPosition.SelectedIndex].ToString(); ;
            string date_started = txtStarted.Text;
            string date_dismissed = txtDismissed.Text;
            string usernmae = txtUsername.Text;
            string password = txtPassword.Text;
            string position_description = txtDesc.Text;

            /*
            try
            {

                sc.OpenConnection();
                if (first_name.Equals("") || last_name.Equals(""))
                {
                    MessageBox.Show("Please enter the name of the product.");
                }
                else
                {

                   if (btnAdd.Text == "ADD USER")
                   {
                       
                       sc.command = sc.SQLCommand("INSERT INTO `users`(`userID`, first_name, middle_initial,last_name,photo,userpriviledgeID,gender,dob,username,password,date_started,date_dismissed,active) "
                       + "VALUES(," + first_name+ "', '" + middle_initial+ "','" + last_name+ "','" + sss+ "',0, "+ price+",1)");
                       sc.command.ExecuteNonQuery();
                       sc.CloseConnection();
                       MessageBox.Show("Your record has been successfully saved.");
                   }
                   else if (btnUpdate.Text == "UPDATE USER")
                   {
                       sc.command = sc.SQLCommand("Update competition "
                         + "Set Name = '" + name + "', "
                         + "Description = '" + desc + "', "
                         + "DateFrom = '" + dFrom + "', "
                         + "DateTo = '" + dTo + "'"
                         + "Where ID = " + get_user_id + "");
                       sc.command.ExecuteNonQuery();
                       MessageBox.Show(name + desc + dFrom + dTo);
                       sc.CloseConnection();
                       MessageBox.Show("Your record has been successfully updated.");

                   }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sc.CloseConnection();
            }
                       */

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void clear_values()
        {
            // Function for Clearing All Values
            // added by Abegail Isidro
            // April 17, 2018


            txtFname.Text = "";
            txtLast.Text = "";
            txtMid.Text = "";
            txtDesc.Text = "";
            txtSearch.Text = "";
            txtUsername.Text = "";
            txtSearch.Focus();
        }
    }
}
