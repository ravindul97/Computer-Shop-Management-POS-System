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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            customer_info f4 = new customer_info();
            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employee_details f5 = new employee_details();
            f5.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            supplier_details f6 = new supplier_details();
            f6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            stock f7 = new stock();
            f7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            add_item f8 = new add_item();
            f8.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

           
        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void cus_details_Click(object sender, EventArgs e)
        {
            customer_info f4 = new customer_info();
            f4.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrEmpty(textBox7.Text))
                textBox8.Text = (Convert.ToDouble(textBox8.Text) * Convert.ToDouble(textBox7.Text)).ToString();
            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                string i_id = textBox9.Text;
                string name = textBox1.Text;
                int price = Convert.ToInt32(textBox8.Text);
                int qty = Convert.ToInt32(textBox7.Text);

                string querystring = "INSERT INTO `sales`(`item_id`, `item_name`, `qty`, `price`) VALUES ('" + i_id + "','" + name + "'," + qty + "," + price + ")";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

                MessageBox.Show("data inserted successfully");
            }
            catch
            {
                MessageBox.Show("An error");
            }

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void main_page_Load(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
            MySqlConnection myconnection = new MySqlConnection(connectionstring);

            //auto suggest ID
            string querystring = "SELECT productid  FROM additem";
            MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

            myconnection.Open();
            MySqlDataReader dr = mycommand.ExecuteReader();
            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();

            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }

            textBox9.AutoCompleteCustomSource = mycollection;

            myconnection.Close();
        }

        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                try
                {
                    string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                    MySqlConnection myconnection = new MySqlConnection(connectionstring);

                    string i_id = textBox9.Text;


                    string querystring = "SELECT * FROM `additem` WHERE `productid`='" + i_id + "'";
                    MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                    myconnection.Open();

                    MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                    DataTable mytb = new DataTable();
                    myadp.Fill(mytb);

                    textBox9.Text = mytb.Rows[0][0].ToString();
                    textBox1.Text = mytb.Rows[0][1].ToString();
                    textBox8.Text = mytb.Rows[0][4].ToString();


                    myconnection.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Sorry, No stock available");
                }
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(connectionstring);

                string i_id = textBox9.Text;


                string querystring = "SELECT * FROM `additem` WHERE `productid`='" + i_id + "'";
                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();

                MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                DataTable mytb = new DataTable();
                myadp.Fill(mytb);

                textBox9.Text = mytb.Rows[0][0].ToString();
                textBox1.Text = mytb.Rows[0][1].ToString();
                textBox8.Text = mytb.Rows[0][4].ToString();


                myconnection.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, No stock available");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox1.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
