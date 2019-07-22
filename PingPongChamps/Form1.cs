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
    public partial class Form1 : Form
    {//Need to load all gates, if End gate on, turn on a random set of buttons, and if still on, randomize again, until you have a button configuration that works...Or, Add a NOT gate to the end if the output is ON.
        bool ison1 = true;
        bool ison2 = true;
        bool ison3 = true;
        bool ison4 = true;
        bool ison5 = true;
        bool ison6 = true;
        bool ison7 = true;
        bool ison8 = true;
        public bool gamestart = false;
        public int whatGates = 0;
        public PictureBox[] Wirepbs = new PictureBox[21];
        Random Rando = new Random();





        Gate[] bottomRow = new Gate[4];
        Gate[] middleRow = new Gate[2];
        Gate[] topRow = new Gate[1];
        Wire WireC;
        End EndGate;//trying to pass current open instance

        public Form1()
        {
            WireC = new Wire(this);
            EndGate = new End(this);
            InitializeComponent();
            Wirepbs[0] = bottomrow0pb;
            Wirepbs[1] = bottomrow1pb;
            Wirepbs[2] = bottomrow2pb;
            Wirepbs[3] = bottomrow3pb;
            Wirepbs[4] = bottomrow4pb;
            Wirepbs[5] = bottomrow5pb;
            Wirepbs[6] = bottomrow6pb;
            Wirepbs[7] = bottomrow7pb;
            Wirepbs[8] = null;
            Wirepbs[9] = null;
            Wirepbs[15] = null;
            Wirepbs[16] = null;
            Wirepbs[17] = null;
            Wirepbs[18] = null;
            Wirepbs[19] = null;
           
            Wirepbs[10] = middlerow0pb;
            Wirepbs[11] = middlerow1pb;
            Wirepbs[12] = middlerow2pb;
            Wirepbs[13] = middlerow3pb;
            Wirepbs[20] = toprow0pb;
            Wirepbs[21] = toprow1pb;
            Wirepbs[14] = lightbulbpb;
        }
        //And 0, Or 1, Nor 2, Nand 3, Xor 4, Xnor 5
        /*int[] SetTopLevelGate = new int[10]                     { 0, 0, 1, 1, 2, 2, 3, 3, 4, 5 };
        int[,] SetMiddleLevel = new int[10, 2] { { 1,0}, { 0,0 }, {1 ,1 }, {0 ,0 }, { , }, { , }, { , }, { , }, { , }, { , } };
        int[,] SetBottomLevel = new int[10, 4] { { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, }, { ,,, } };
        int[,] SetButtonOnOff = new int[10, 8] { { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, }, { ,,,,,,, } };
        */
        private void Playey1Paddle_Click(object sender, EventArgs e)
        {

        }
        public void Randomize(int max)
        {
            int spacer = 15;
            int min = 0;

            //outwire is if the outline is the left or right input of the above gate (0 or 1)
            //gatename(first val,outwirenum): first val is the name of the gate above that gate, the one it reports to
            //for the starting buttons, when one is pressed it just activates its connected gates toggle line and corrosponding wire num. if it is the 0 wire, or 1 wire.
            switch (Rando.Next(min, max))
            {
                case 0:
                    topRow[0] = new AndGate(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "And";
                    break;
                case 1:
                    topRow[0] = new OrGate(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "Or";
                    break;
                case 2:
                    topRow[0] = new NorGate(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "Nor";
                    break;
                case 3:
                    topRow[0] = new Nand(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "Nand";
                    break;
                case 4:
                    topRow[0] = new XorGate(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "Xor";
                    break;
                case 5:
                    topRow[0] = new XnorGate(EndGate, 0, Wirepbs[14]);
                    topRow[0].Text = "Xnor";
                    break;
                default:
                    break;
            }

            this.Controls.Add(topRow[0]);
            topRow[0].BackColor = System.Drawing.Color.Transparent;
            topRow[0].Location = new Point(this.Width / 2 - 90, 105);



            topRow[0].BringToFront();
            //randomizes which things are where
            int switching = 0;
            for (int i = 0; i < middleRow.Length; i++)
            {

                switch (Rando.Next(min, max))
                { //And 0, Or 1, Nor 2, Nand 3, Xor 4, Xnor 5
                    case 0:
                        middleRow[i] = new AndGate(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "And";
                        break;
                    case 1:
                        middleRow[i] = new OrGate(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "Or";
                        break;
                    case 2:
                        middleRow[i] = new NorGate(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "Nor";
                        break;
                    case 3:

                        middleRow[i] = new Nand(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "Nand";
                        break;
                    case 4:
                        middleRow[i] = new XorGate(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "Xor";
                        break;
                    case 5:
                        middleRow[i] = new XnorGate(topRow[0], switching, Wirepbs[i + 20]);
                        middleRow[i].Text = "Xnor";
                        break;
                    default:
                        break;
                }
                if (switching > 0) switching = 0;
                else { switching++; }

                this.Controls.Add(middleRow[i]);

                middleRow[i].BackColor = System.Drawing.Color.Transparent;
                middleRow[i].BringToFront();
            }
            middleRow[0].Location = new Point(this.Width / 8 + spacer, 180);
            middleRow[1].Location = new Point(this.Width / 8 * 4 + spacer - 20, 180);
            int switching2 = 0;
            for (int i = 0; i < bottomRow.Length; i++)
            {
                //need to implement counter to set each new rounds above gate in middle row/ check if the i-a thing is working
                int b = (i % 1 == 0 ? i / 2 : i / 2 - 1);//Based on which number it is in the counter, because the level above is always 2 less values(because 2 of the below gates go to 1) I can rotate between if the number is 0, 1, 2, 3.
                switch (Rando.Next(min, max))
                {
                    case 0:
                        bottomRow[i] = new AndGate(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "And";
                        break;
                    case 1:
                        bottomRow[i] = new OrGate(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "Or";
                        break;
                    case 2:
                        bottomRow[i] = new NorGate(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "Nor";
                        break;
                    case 3:
                        bottomRow[i] = new Nand(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "Nand";
                        break;
                    case 4:

                        bottomRow[i] = new XorGate(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "Xor";
                        break;
                    case 5:
                        bottomRow[i] = new XnorGate(middleRow[b], switching2, Wirepbs[i + 10]);
                        bottomRow[i].Text = "Xnor";
                        break;
                    default:
                        break;
                }
                if (switching2 > 0) switching2 = 0;
                else { switching2++; }
                this.Controls.Add(bottomRow[i]);

                bottomRow[i].BackColor = System.Drawing.Color.Transparent;
                bottomRow[i].BringToFront();
            }

            bottomRow[0].Location = new Point(23 + spacer, 240);
            bottomRow[1].Location = new Point(93 + spacer, 240);
            bottomRow[2].Location = new Point(185 + spacer, 240);
            bottomRow[3].Location = new Point(256 + spacer, 240);


            bottomRow[0].ToggleLine(true, 0);
            bottomRow[1].ToggleLine(true, 0);
            bottomRow[2].ToggleLine(true, 0);
            bottomRow[3].ToggleLine(true, 0);
            bottomRow[0].ToggleLine(false, 0);
            bottomRow[1].ToggleLine(false, 0);
            bottomRow[2].ToggleLine(false, 0);
            bottomRow[3].ToggleLine(false, 0);
            //trying to load all the different logic gates, because in level 2+ they can be automatically on, as like Nand, it turns on as it requires no inputs or 1 input. so need to find a way to load the logic gates and to turn on some buttons so that they are off, or maybe randomize which buttoms are on, till the game works.
            gamestart = true;
        }
        public void RandomizeButtonOn()
        {

        }



        public void Winner()
        {
            if (gamestart)
            {
                winBlocker.BringToFront();
                winBlocker.BackColor = Color.Black;
                label1.BringToFront();
                label1.Text = "You Win!";
            }
            else
            {

            }
        }

        public void Mainsetup()
        {
            //Need to fix difficulty issues with, wrong difficulty given., need to get index value from list, not string, as Lvl's is skipping ot default and not selecting correctly.
            switch (StartGame.difficulty)
            {
                case 0:
                    whatGates = 2;
                    break;
                case 1:
                    whatGates = 4;
                    break;
                case 2:
                    whatGates = 6;
                    break;
                default:
                    throw new Exception();
            }

            Randomize(whatGates);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Mainsetup();
        }        
        private void btn1_Click(object sender, EventArgs e)
        {
            if (ison1)
            {
                bottomRow[0].ToggleLine(true, 0);
                ison1 = false;
                btn1.Text = "On";
                btn1.BackColor = Color.Blue;
                Wirepbs[0].BackColor = Color.Red;
            }
            else
            {
                bottomRow[0].ToggleLine(false, 0);
                ison1 = true;
                btn1.Text = "Off";
                btn1.BackColor = Color.Red;
                Wirepbs[0].BackColor = Color.Red;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ison2)
            {
                bottomRow[0].ToggleLine(true, 1);
                ison2 = false;
                btn2.Text = "On";
                btn2.BackColor = Color.Blue;
                Wirepbs[1].BackColor = Color.Red;
            }
            else
            {
                bottomRow[0].ToggleLine(false, 1);
                ison2 = true;
                btn2.Text = "Off";
                btn2.BackColor = Color.Red;
                Wirepbs[1].BackColor = Color.Red;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ison3)
            {
                bottomRow[1].ToggleLine(true, 0);
                ison3 = false;
                btn3.Text = "On";
                btn3.BackColor = Color.Blue;
                Wirepbs[2].BackColor = Color.Red;
            }
            else
            {
                bottomRow[1].ToggleLine(false, 0);
                ison3 = true;
                btn3.Text = "Off";
                btn3.BackColor = Color.Red;
                Wirepbs[2].BackColor = Color.Red;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ison4)
            {
                bottomRow[1].ToggleLine(true, 1);
                ison4 = false;
                btn4.Text = "On";
                btn4.BackColor = Color.Blue;
                Wirepbs[3].BackColor = Color.Red;
            }
            else
            {
                bottomRow[1].ToggleLine(false, 1);
                ison4 = true;
                btn4.Text = "Off";
                btn4.BackColor = Color.Red;
                Wirepbs[3].BackColor = Color.Red;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ison5)
            {
                bottomRow[2].ToggleLine(true, 0);
                ison5 = false;
                btn5.Text = "On";
                btn5.BackColor = Color.Blue;
                Wirepbs[4].BackColor = Color.Red;
            }
            else
            {
                bottomRow[2].ToggleLine(false, 0);
                ison5 = true;
                btn5.Text = "Off";
                btn5.BackColor = Color.Red;
                Wirepbs[4].BackColor = Color.Red;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ison6)
            {
                bottomRow[2].ToggleLine(true, 1);
                ison6 = false;
                btn6.Text = "On";
                btn6.BackColor = Color.Blue;
                Wirepbs[5].BackColor = Color.Red;
            }
            else
            {
                bottomRow[2].ToggleLine(false, 1);
                ison6 = true;
                btn6.Text = "Off";
                btn6.BackColor = Color.Red;
                Wirepbs[5].BackColor = Color.Red;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ison7)
            {
                bottomRow[3].ToggleLine(true, 0);
                ison7 = false;
                btn7.Text = "On";
                btn7.BackColor = Color.Blue;
                Wirepbs[6].BackColor = Color.Red;
            }
            else
            {
                bottomRow[3].ToggleLine(false, 0);
                ison7 = true;
                btn7.Text = "Off";
                btn7.BackColor = Color.Red;
                Wirepbs[6].BackColor = Color.Red;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ison8)
            {
                bottomRow[3].ToggleLine(true, 1);
                ison8 = false;
                btn8.Text = "On";
                btn8.BackColor = Color.Blue;
                Wirepbs[7].BackColor = Color.Red;
            }
            else
            {
                bottomRow[3].ToggleLine(false, 1);
                ison8 = true;
                btn8.Text = "Off";
                btn8.BackColor = Color.Red;
                Wirepbs[7].BackColor = Color.Red;
            }
        }

        private void btn1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn1.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn2.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn3.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn4.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn5.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn6.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn7.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void btn8_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btn8.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        //Making set levels to randomly rotate through.





    }

}




