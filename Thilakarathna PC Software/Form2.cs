using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Thilakarathna_PC_Software
{
    public partial class login : Form
    {
        public login()
        {
            
            InitializeComponent();

        }

        public void SplashStart() {
                                   Application.Run(new loading());
                                   }

        public void StartForm() {
                                    Application.Run(new loading());
                                 }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionstring = "server=localhost; userid=root; password=;database=thilakarathna_pc_center;";
            MySqlConnection myconnection = new MySqlConnection(connectionstring);

            string username = user_name.Text;
            string password = passw.Text;

            string querystring = "SELECT * FROM `user` WHERE `username` ='" + username + "' AND `password`='" + password + "';";
            MySqlCommand mycommand = new MySqlCommand(querystring, myconnection);
            myconnection.Open();

            MySqlDataAdapter myadp = new MySqlDataAdapter(mycommand);
            DataTable mytb = new DataTable();
            myadp.Fill(mytb);


            if (mytb.Rows.Count > 0)
            {
                string level = mytb.Rows[0][3].ToString();
                if (level == "1")
                {
                    main_page c = new main_page();
                    c.Show();
                    this.Hide();
                }
                else if (level == "2")
                {
                    main_page c = new main_page();
                    c.Show();
                    this.Hide();
                }
                else if (level == "4")
                {
                    main_page c = new main_page();
                    c.Show();
                    this.Hide();
                }
                else if (level == "3")
                {
                    main_page c = new main_page();
                    c.Show();
                    this.Hide();
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            myconnection.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            user_name.Text = "";
            passw.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passw_TextChanged(object sender, EventArgs e)
        {
            passw.UseSystemPasswordChar = true;
        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
