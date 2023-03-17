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
    public partial class employee_details : Form
    {
        public employee_details()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(con);

                string id = text_emp_id.Text;
                string fname = text_emp_fname.Text;
                string lname = text_emp_lname.Text;
                string nic = text_emp_nic.Text;
                string address = text_emp_address.Text;
                string tel = text_emp_tel.Text;
                string gender = text_emp_gender.Text;
                string email = text_emp_email.Text;
                string doj = text_emp_doj.Text;
                string salary = text_emp_salary.Text;

                string querystring = " INSERT INTO `employee_detail`(`id`, `nic`, `fname`, `lname`, `address`, `tel`, `gender`, `email`, `doj`, `salary`) VALUES ('"+id+"','"+nic+"','"+fname+"','"+lname+"','"+address+"','"+tel+"','"+gender+"','"+email+"','"+doj+"','"+salary+"')";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data inserted successfully");

                text_emp_id.Text = "";
                text_emp_fname.Text = "";
                text_emp_lname.Text = "";
                text_emp_nic.Text = "";
                text_emp_address.Text = "";
                text_emp_tel.Text = "";
                text_emp_gender.Text = "";
               text_emp_email.Text = "";
               text_emp_doj.Text = "";
               text_emp_salary.Text = "";

            }
            catch
            {
                MessageBox.Show("error occured in inserting");
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            text_emp_id.Text = "";
            text_emp_nic.Text = "";
            text_emp_fname.Text = "";
            text_emp_lname.Text = "";
            text_emp_address.Text = "";
            text_emp_tel.Text = "";
            text_emp_gender.Text = "";
            text_emp_email.Text = "";
            text_emp_doj.Text = "";
            text_emp_salary.Text = "";

        }

        private void search_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                int id = Convert.ToInt32(text_emp_id.Text);

                string querystring = "SELECT * FROM `employee_detail` WHERE `id`=" + id + "";
                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();

                MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                DataTable mytb = new DataTable();
                myadp.Fill(mytb);

                text_emp_nic.Text = mytb.Rows[0][1].ToString();
                text_emp_fname.Text = mytb.Rows[0][2].ToString();
                text_emp_lname.Text = mytb.Rows[0][3].ToString();
                text_emp_address.Text = mytb.Rows[0][4].ToString();
                text_emp_tel.Text = mytb.Rows[0][5].ToString();
                text_emp_gender.Text = mytb.Rows[0][6].ToString();
                text_emp_email.Text = mytb.Rows[0][7].ToString();
                text_emp_doj.Text = mytb.Rows[0][8].ToString();
                text_emp_salary.Text = mytb.Rows[0][9].ToString();

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

                int id = Convert.ToInt32(text_emp_id.Text);
                string nic = text_emp_nic.Text;
                string fname = text_emp_fname.Text;
                string lname = text_emp_lname.Text;
                string address = text_emp_address.Text;
                string tel = text_emp_tel.Text;
                string gender = text_emp_gender.Text;
                string email = text_emp_email.Text;
                string doj = text_emp_doj.Text;
                string salary = text_emp_salary.Text;


                string querystring = "UPDATE `employee_detail` SET `nic`='" + nic + "',`fname`='" + fname + "',`lname`='" + lname + "',`address`='" + address + "',`tel`='" + tel + "',`gender`='" + gender + "',`email`='" + email + "',`doj`='" + doj + "',`salary`='" + salary + "' WHERE `id`=" + id + "";
                
                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data udtated successfully");

                text_emp_id.Text = "";
                text_emp_nic.Text = "";
                text_emp_fname.Text = "";
                text_emp_lname.Text = "";
                text_emp_address.Text = "";
                text_emp_tel.Text = "";
                text_emp_gender.Text = "";
                text_emp_address.Text = "";
                text_emp_email.Text = "";
                text_emp_doj.Text = "";
                text_emp_salary.Text = "";

            }
            catch 
            {
                MessageBox.Show("An error");
            }
        }
    }
}
