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
    public partial class add_item : Form
    {
        public add_item()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
                string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";
                MySqlConnection myconnection = new MySqlConnection(con);

                string productid = item_id.Text;
                string productname = item_name.Text;
                string description = item_description.Text;
                string quantity = item_quantity.Text;
                string price = item_price.Text;

                string querystring = " INSERT INTO `additem`(`productid`, `productname`, `description`, `quantity`, `price`) VALUES ('" + productid + "','" + productname + "','" + description + "','" + quantity + "','" + price + "')";

                MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                myconnection.Open();
                mycommand.ExecuteNonQuery();
                myconnection.Close();

            // to add valus to data grid
             
                MySqlConnection myconnection3 = new MySqlConnection(con);

                string id = item_id.Text;

                string querystring3 = "SELECT * FROM `additem` WHERE `productid`='" + id + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            item_id.Text = "";
            item_name.Text = "";
            item_description.Text = "";
            item_quantity.Text = "";
            item_price.Text = "";
            text_available_qty.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void item_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)


                
                {
                    string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
                    MySqlConnection myconnection = new MySqlConnection(connectionstring);

                    string id = item_id.Text;

                    string querystring = "SELECT * FROM `additem` WHERE `productid`='" + id + "'";
                    MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

                    myconnection.Open();

                    MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
                    DataTable mytb = new DataTable();
                    myadp.Fill(mytb);


                    item_name.Text = mytb.Rows[0][1].ToString();
                    item_description.Text = mytb.Rows[0][2].ToString();
                    text_available_qty.Text = mytb.Rows[0][3].ToString();
                    item_price.Text = mytb.Rows[0][4].ToString();

                    myconnection.Close();

                    
                }
               
                
        }

        private void add_item_Load(object sender, EventArgs e)
        {
            string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";

            //suggest append brand name
            MySqlConnection myconnection = new MySqlConnection(connectionstring);

            string querystring = "SELECT productid FROM additem";


            MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);

            myconnection.Open();
            MySqlDataReader dr = mycommand.ExecuteReader();

            AutoCompleteStringCollection mycollection = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                mycollection.Add(dr.GetString(0));
            }
            item_id.AutoCompleteCustomSource = mycollection;

            myconnection.Close();
        }

        private void item_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_available_qty.Text = (Convert.ToDouble(text_available_qty.Text) + Convert.ToDouble(item_quantity.Text)).ToString();


           
        }
    }
}
