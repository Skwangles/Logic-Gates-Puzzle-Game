using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    public partial class Instructions : Form
    {
        Form1 g;
       
        public Instructions(Form1 form1)
        {
            g = form1;

            InitializeComponent();
            HideButton();
        }  
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HideButton()
        {
            if (g == null)
            {
                continueButton.Hide();
            }
            else
            {
                continueButton.Show();
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            g.ShowDialog();
           
        }

      
        
        private void Instructions_Load(object sender, EventArgs e)
        {

        }

        private void lblinfotxt_Click(object sender, EventArgs e)
        {

        }
    }
}
