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
        Form winFormGatesExplain = new Explain();
       
        public static int[] highscores = new int[3]; //Highscore and Difficulty values so that all methods can reach it.
        public static int difficulty;
        int secondTimeRound = 0;
        public StartGame()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Form1 winForm1 = new Form1();//Sets the instances of each window
            Form winFormInstruction = new Instructions(winForm1); //Sets the playing instance of Instructions which has the Continue button
            winForm1.StartGameSet = this;//Sets the Form1 f Instance for other methods
            if (listBoxlvlselect.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Level", null); //Sets the messagebox values
            }
            else
            {
                difficulty = listBoxlvlselect.SelectedIndex;

                if (secondTimeRound == 0)//Disables the instructions screen for second time playing a round. So that it is not annoying the player
                {

                    winFormInstruction.ShowDialog();
                }
                else
                {
                    winForm1.ShowDialog();
                }
                secondTimeRound++;
            }
        }
        public string SetHighScore1
        {
         
            set { lbllvl1num.Text = value; }//Getter/setter for the text of the highscore lbls
        }
        public string SetHighScore2//^
        {
          
            set { lblLvl2num.Text = value; }
        }
        public string SetHighScore3//^
        {
            
            set { lblLvl3num.Text = value; }
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

            winFormGatesExplain.ShowDialog();//Opens the gates explain window.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form b = new Instructions(null); //Opens the instructions window, and hides the button to continue in order to prevent error.
            b.ShowDialog();
            secondTimeRound++;//disables the instructions from showing up when play is pressed, even though not playing the game.
        }
    }
}
