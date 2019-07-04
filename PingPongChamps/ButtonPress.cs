using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PingPongChamps
{
    class ButtonPress
    {
        public ButtonPress(Form1 formm, int bottomRow, int wirenum, Button mybtn, Gate[] bR )
        {
            this.br = bR;
            this.formm = formm;
            this.wirenum = wirenum;
            this.Gatenum = bottomRow;
            this.mybtn = mybtn;
        }
        public Gate[] br;
        public Button mybtn;
        public Form1 formm;
        public int wirenum;
        public int Gatenum;
        public bool[] button;
        public void ToggleButton(bool ison1)
        {
            if (ison1)
            {
                
                formm.[0].ToggleLine(true, 0);
                ison1 = false;
                mybtn.Text = "On";
                //formm.mybtn.BackColor = Color.Blue;    Need to change so that the button on Form1 is changed, so that looks change.

            }
            else
            {
                //bottomRow[0].ToggleLine(false, 0);
                //ison1 = true;
                //btn1.Text = "Off";
                //btn1.BackColor = Color.Red;
            }


        }
    }
}
