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
        bool ison1 = false;
        bool ison2 = false;
        bool ison3 = false;
        bool ison4 = false;
        bool ison5 = false;
        bool ison6 = false;
        bool ison7 = false;
        bool ison8 = false;
        Gate[] bottomRow = new Gate[4];
        Gate[] middleRow = new Gate[2];
        Gate[] topRow = new Gate[1];
        End EndGate = new End(null, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void Playey1Paddle_Click(object sender, EventArgs e)
        {

        }




        private void Randomize()
        {
            int randomdef()
            {
                int min = 0;
                int max = 6;
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
                    topRow[0] = new XorGate(EndGate, 0);

                    break;
                case 4:
                    topRow[0] = new Nand(EndGate, 0);

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

        private void Form1_Load(object sender, EventArgs e)
        {

            Randomize();



        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ison1)
            {
                bottomRow[0].ToggleLine(true, 0);
                ison1 = false;
            }
            else
            {
                bottomRow[0].ToggleLine(false, 0);
                ison1 = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ison2)
            {
                bottomRow[0].ToggleLine(true, 1);
                ison2 = false;
            }
            else
            {
                bottomRow[0].ToggleLine(false, 1);
                ison2 = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ison3)
            {
                bottomRow[1].ToggleLine(true, 0);
                ison3 = false;
            }
            else
            {
                bottomRow[1].ToggleLine(false, 0);
                ison3 = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ison4)
            {
                bottomRow[1].ToggleLine(true, 1);
                ison4 = false;
            }
            else
            {
                bottomRow[1].ToggleLine(false, 1);
                ison4 = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ison5)
            {
                bottomRow[2].ToggleLine(true, 0);
                ison5 = false;
            }
            else
            {
                bottomRow[2].ToggleLine(false, 0);
                ison5 = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ison6)
            {
                bottomRow[2].ToggleLine(true, 1);
                ison6 = false;
            }
            else
            {
                bottomRow[2].ToggleLine(false, 1);
                ison6 = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ison7)
            {
                bottomRow[3].ToggleLine(true, 0);
                ison7 = false;
            }
            else
            {
                bottomRow[3].ToggleLine(false, 0);
                ison7 = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ison8)
            {
                bottomRow[3].ToggleLine(true, 1);
                ison8 = false;
            }
            else
            {
                bottomRow[3].ToggleLine(false, 1);
                ison8 = true;
            }
        }
    }
}
