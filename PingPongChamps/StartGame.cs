﻿using System;
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
        public static int highscore = 0;
        public static int difficulty;
        int secondTimeRound = 0;
        public StartGame()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            Form a = new Instructions(f);
            f.StartGameSet = this;
            if (listBoxlvlselect.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Level", null);
            }
            else
            {
                difficulty = listBoxlvlselect.SelectedIndex;

                if (secondTimeRound == 0)
                {

                    a.ShowDialog();
                }
                else
                {
                    f.ShowDialog();
                }
                secondTimeRound++;
            }
        }
        public string SetHighscore
        {
            set { lblhighscorenum.Text = value; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form b = new Instructions(null);
            b.ShowDialog();
            secondTimeRound++;
        }
    }
}
