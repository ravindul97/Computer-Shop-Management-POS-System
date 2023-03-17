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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Motherboard";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "ram";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Power supply";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Monitor";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Hard drive";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Graphic card";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Computer case";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "cabel";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button10_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "ups";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button15_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "flash drive";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button14_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Sound card";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button13_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "DVD writer";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button12_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Mouse";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "keyboard";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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
        }

        private void processor_Click(object sender, EventArgs e)
        {
            text_item_name.Text = "Processor";

            string con = "server=localhost; username=root; password=;database=thilakarathna_pc_center;";

            MySqlConnection myconnection3 = new MySqlConnection(con);

            string iname = text_item_name.Text;

            string querystring3 = "SELECT * FROM `additem` WHERE `productname`='" + iname + "'";
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


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_item_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
