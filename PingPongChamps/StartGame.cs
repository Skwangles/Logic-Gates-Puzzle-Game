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
        public static string Difficulty;
        public StartGame()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a Difficulty", "Level not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Form f = new Form1();
                f.ShowDialog();
                string d = listBox1.GetItemText(listBox1.SelectedItem);
                Difficulty = d;
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
    }
}
