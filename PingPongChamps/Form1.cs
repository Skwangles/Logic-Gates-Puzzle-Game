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
    {
        bool ison1 = true;
        bool ison2 = true;
        bool ison3 = true;
        bool ison4 = true;
        bool ison5 = true;
        bool ison6 = true;
        bool ison7 = true;
        bool ison8 = true;
        
        Gate[] bottomRow = new Gate[4];
        Gate[] middleRow = new Gate[2];
        Gate[] topRow = new Gate[1];
        End EndGate = new End(null, 0 );//trying to pass current open instance
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Playey1Paddle_Click(object sender, EventArgs e)
        {

        }




        private void Randomize(int max)
        {
            int randomdef()
            {
                int min = 0;
                
                Random Rando = new Random();
                return Rando.Next(min, max);
            }
            //outwire is if the outline is the left or right input of the above gate (0 or 1)
            //gatename(first val,outwirenum): first val is the name of the gate above that gate, the one it reports to
            //for the starting buttons, when one is pressed it just activates its connected gates toggle line and corrosponding wire num. if it is the 0 wire, or 1 wire.
            switch (randomdef())
            {
                case 0:
                    topRow[0] = new AndGate(EndGate, 0);
                    break;
                case 1:
                    topRow[0] = new OrGate(EndGate, 0);

                    break;
                case 2:
                    topRow[0] = new NorGate(EndGate, 0);

                    break;
                case 3:
                    topRow[0] = new Nand(EndGate, 0);

                    break;
                case 4:
                    topRow[0] = new XorGate(EndGate, 0);

                    break;
                case 5:
                    topRow[0] = new XnorGate(EndGate, 0);

                    break;
                default:
                    break;
            }
            //randomizes which things are where
            int a = 0;
            for (int i = 0; i < middleRow.Length; i++)
            {

                switch (randomdef())
                {
                    case 0:
                        middleRow[i] = new AndGate(topRow[0], a);
                        break;
                    case 1:
                        middleRow[i] = new OrGate(topRow[0], a);

                        break;
                    case 2:
                        middleRow[i] = new NorGate(topRow[0], a);

                        break;
                    case 3:
                        middleRow[i] = new XorGate(topRow[0], a);

                        break;
                    case 4:
                        middleRow[i] = new Nand(topRow[0], a);

                        break;
                    case 5:
                        middleRow[i] = new XnorGate(topRow[0], a);

                        break;
                    default:
                        break;
                }
                if (a > 0) a = 0;
                else { a++; }
            }
            a = 0;
            for (int i = 0; i < bottomRow.Length; i++)
            {
                //need to implement counter to set each new rounds above gate in middle row/ check if the i-a thing is working
                int b = (i % 1 == 0 ? i / 2 : i / 2 - 1);
                switch (randomdef())
                {
                    case 0:
                        bottomRow[i] = new AndGate(middleRow[b], a);
                        break;
                    case 1:
                        bottomRow[i] = new OrGate(middleRow[b], a);

                        break;
                    case 2:
                        bottomRow[i] = new NorGate(middleRow[b], a);

                        break;
                    case 3:
                        bottomRow[i] = new XorGate(middleRow[b], a);

                        break;
                    case 4:
                        bottomRow[i] = new Nand(middleRow[b], a);

                        break;
                    case 5:
                        bottomRow[i] = new XnorGate(middleRow[b], a);

                        break;
                    default:
                        break;
                }
                if (a > 0) a = 0;
                else { a++; }
            }
        }
        public void WinCondition()
        {
            
            WinBlocker.BringToFront();
            WinBlocker.BackColor = Color.Black;
            label1.BringToFront();
            label1.Text = "You Win!";

        }



        private void Form1_Load(object sender, EventArgs e)
        {
          
            int al = 0;
            switch (StartGame.Difficulty)
            {
                case "Level 1 - Or, And.":
                    al = 2;
                    break;
                case "Level 2 - Nor, Nand.":
                    al = 4;
                    break;
                case "Level 3 - Xnor, Xor.":
                    al = 6;
                    break;

            }

            Randomize(al);



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ison1)
            {
                bottomRow[0].ToggleLine(true, 0);
                ison1 = false;
                btn1.Text = "On";
                btn1.BackColor = Color.Blue;

            }
            else
            {
                bottomRow[0].ToggleLine(false, 0);
                ison1 = true;
                btn1.Text = "Off";
                btn1.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[0].ToggleLine(false, 1);
                ison2 = true;
                btn2.Text = "Off";
                btn2.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[1].ToggleLine(false, 0);
                ison3 = true;
                btn3.Text = "Off";
                btn3.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[1].ToggleLine(false, 1);
                ison4 = true;
                btn4.Text = "Off";
                btn4.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[2].ToggleLine(false, 0);
                ison5 = true;
                btn5.Text = "Off";
                btn5.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[2].ToggleLine(false, 1);
                ison6 = true;
                btn6.Text = "Off";
                btn6.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[3].ToggleLine(false, 0);
                ison7 = true;
                btn7.Text = "Off";
                btn7.BackColor = Color.Red;
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
            }
            else
            {
                bottomRow[3].ToggleLine(false, 1);
                ison8 = true;
                btn8.Text = "Off";
                btn8.BackColor = Color.Red;
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
    }
}
