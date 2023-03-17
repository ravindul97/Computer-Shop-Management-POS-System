using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Thilakarathna_PC_Software
{
    public partial class supplier_details : Form
    {
        public supplier_details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text_sup_id.Text = "";
            text_sup_nic.Text = "";
            text_sup_fname.Text = "";
            text_sup_lname.Text = "";
            text_sup_address.Text = "";
            text_sup_tel.Text = "";
            text_sup_email.Text = "";
            text_supply_of.Text = "";

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(con);

                string id = text_sup_id.Text;
                string fname = text_sup_fname.Text;
                string lname = text_sup_lname.Text;
                string nic = text_sup_nic.Text;
                string address = text_sup_address.Text;
                string tel = text_sup_tel.Text;
                string email = text_sup_email.Text;
                string supply_of = text_supply_of.Text;

                string querystring = " INSERT INTO `supplier_detail`(`id`, `nic`, `fname`, `lname`, `address`, `tel`, `email`, `supply_of`) VALUES ('"+id+"','"+nic+"','"+fname+"','"+lname+"','"+address+"','"+tel+"','"+email+"','"+supply_of+"')";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data inserted successfully");

                text_sup_id.Text = "";
                text_sup_fname.Text = "";
                text_sup_lname.Text = "";
                text_sup_nic.Text = "";
                text_sup_address.Text = "";
                text_sup_tel.Text = "";
                text_sup_email.Text = "";
                text_supply_of.Text = "";

            }
            catch
            {
                MessageBox.Show("error occured in inserting");
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                int id = Convert.ToInt32(text_sup_id.Text);

                string querystring = "SELECT * FROM `supplier_detail` WHERE `id`=" + id + "";
                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();

                MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                DataTable mytb = new DataTable();
                myadp.Fill(mytb);

                text_sup_nic.Text = mytb.Rows[0][1].ToString();
                text_sup_fname.Text = mytb.Rows[0][2].ToString();
                text_sup_lname.Text = mytb.Rows[0][3].ToString();
                text_sup_address.Text = mytb.Rows[0][4].ToString();
                text_sup_tel.Text = mytb.Rows[0][5].ToString();
                text_sup_email.Text = mytb.Rows[0][6].ToString();
                text_supply_of.Text = mytb.Rows[0][7].ToString();

                myconnection.Close();
            }
            catch
            {
                MessageBox.Show("An error");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";

                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                int id = Convert.ToInt32(text_sup_id.Text);
                string nic = text_sup_nic.Text;
                string fname = text_sup_fname.Text;
                string lname = text_sup_lname.Text;
                string address = text_sup_address.Text;
                string tel = text_sup_tel.Text;
                string email = text_sup_email.Text;
                string supply_of = text_supply_of.Text;


                string querystring = "UPDATE `supplier_detail` SET `nic`='" + nic + "',`fname`='" + fname + "',`lname`='" + lname + "',`address`='" + address + "',`email`='" + email + "',`supply_of`='" + supply_of + "' WHERE `id`=" + id + "";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data udtated successfully");

                text_sup_id.Text = "";
                text_sup_fname.Text = "";
                text_sup_lname.Text = "";
                text_sup_nic.Text = "";
                text_sup_address.Text = "";
                text_sup_tel.Text = "";
                text_sup_email.Text = "";
                text_supply_of.Text = "";

            }
            catch 
            {
                MessageBox.Show("An error");
            }
            
        }
    }
}
