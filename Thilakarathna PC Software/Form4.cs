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
    public partial class customer_info : Form
    {
        public customer_info()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(con);

                string id = text_cus_id.Text;
                string fname = text_cus_fname.Text;
                string lname = text_cus_lname.Text;
                string nic = text_cus_nic.Text;
                string address = text_cus_address.Text;
                string tel = text_cus_tel.Text;
                string email = text_cus_email.Text;

                string querystring = "INSERT INTO `customer_info`(`id`, `fname`, `lname`, `nic`, `address`, `tel`, `email`) VALUES ('"+id+"','"+fname+"','"+lname+"','"+nic+"','"+address+"','"+tel+"','"+email+"')";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                // to add valus to data grid

                MySqlConnection myconnection3 = new MySqlConnection(con);

                string customerid = text_cus_id.Text;
 

                string querystring3 = "SELECT * FROM `customer_info` WHERE `id`='" + customerid + "'";
                MySqlCommand mycommand2 = new MySqlCommand(querystring3, myconnection3);

                myconnection3.Open();

                MySqlDataAdapter myadp1 = new MySqlDataAdapter(mycommand2);
                DataTable mytb1 = new DataTable();
                myadp1.Fill(mytb1);

                BindingSource bSource1 = new BindingSource();
                bSource1.DataSource = mytb1;


                bSource1.DataSource = mytb1;
                dataGridView1.DataSource = bSource1;

                myconnection3.Close();

                MessageBox.Show("data inserted successfully");

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

                int id = Convert.ToInt32(text_cus_id.Text);

                string querystring = "SELECT * FROM `customer_info` WHERE `id`=" + id + "";
                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();

                MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                DataTable mytb = new DataTable();
                myadp.Fill(mytb);

                text_cus_fname.Text = mytb.Rows[0][1].ToString();
                text_cus_lname.Text = mytb.Rows[0][2].ToString();
                text_cus_nic.Text = mytb.Rows[0][3].ToString();
                text_cus_address.Text = mytb.Rows[0][4].ToString();
                text_cus_tel.Text = mytb.Rows[0][5].ToString();
                text_cus_email.Text = mytb.Rows[0][6].ToString();

                myconnection.Close();
            }
            catch
            {
                MessageBox.Show("An error");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text_cus_id.Text = "";
            text_cus_fname.Text = "";
            text_cus_lname.Text = "";
            text_cus_nic.Text = "";
            text_cus_address.Text = "";
            text_cus_tel.Text = "";
            text_cus_email.Text = "";


        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";

                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                int id = Convert.ToInt32(text_cus_id.Text);
                string fname = text_cus_fname.Text;
                string lname = text_cus_lname.Text;
                string nic = text_cus_nic.Text;
                string address = text_cus_address.Text;
                string tel = text_cus_tel.Text;
                string email = text_cus_email.Text;


                string querystring = "UPDATE `customer_info` SET `fname`='" + fname + "',`lname`='" + lname + "',`nic`='" + nic + "',`address`='" + address + "',`tel`='" + tel + "',`email`='" + email + "' WHERE `id`=" + id + "";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data udtated successfully");

                text_cus_id.Text = "";
                text_cus_fname.Text = "";
                text_cus_lname.Text = "";
                text_cus_nic.Text = "";
                text_cus_address.Text = "";
                text_cus_tel.Text = "";
                text_cus_email.Text = "";

            }
            catch
            {
                MessageBox.Show("An error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
