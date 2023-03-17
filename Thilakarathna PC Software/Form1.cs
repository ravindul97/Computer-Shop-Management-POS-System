using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Thilakarathna_PC_Software
{
    public partial class loading : Form
    {
        public loading()
        {

            InitializeComponent();
            timer1.Enabled = true;
            
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);

            label1.Text = progressBar.Value.ToString() + "%";

            if (progressBar.Value == 100)  {
                                                timer1.Enabled = false;
                                                timer1.Stop();
                                                this.Hide();

                                                login l = new login();
                                                l.Show();
                                                this.Hide();
              
                                            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
