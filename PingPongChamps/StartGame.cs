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
    public partial class StartGame : Form
    {
        Form o = new Explain();
        public static int Difficulty;
       
        public StartGame()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a Difficulty", "Level not selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                             
                Form f = new Form1();
                Difficulty = listBox1.SelectedIndex;
                f.ShowDialog();
               
                
                
            }
          
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartGame_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExplainsLGbtn_Click(object sender, EventArgs e)
        {
            
            o.ShowDialog();
        }
    }
}
