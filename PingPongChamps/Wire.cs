using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    class Wire : PictureBox
    {

        public Form1 form1;
        public Wire(Form1 form1)
        {
           this.form1 = form1;
        }

        private bool on = false;
        public void ToggleWire(int placed)
        {
            if (on)
            {
                on = false;
                switch (placed)
                {
                    case 0: //Need to implement call inside program. By when the different gates are defined, they are given a case. or "Place" which is to be defined, and will toggle the colors of the pbs/wires
                        form1.wirepbs[0].BackColor = System.Drawing.Color.Red;
                        break;
                    case 1:
                        form1.wirepbs[1].BackColor = System.Drawing.Color.Red;
                        break;
                    case 2:
                        form1.wirepbs[2].BackColor = System.Drawing.Color.Red;
                        break;
                    case 3:
                        form1.wirepbs[3].BackColor = System.Drawing.Color.Red;
                        break;
                    case 4:
                        form1.wirepbs[4].BackColor = System.Drawing.Color.Red;
                        break;
                    case 5:
                        form1.wirepbs[5].BackColor = System.Drawing.Color.Red;
                        break;
                    case 6:
                        form1.wirepbs[6].BackColor = System.Drawing.Color.Red;
                        break;
                    case 7:
                        form1.wirepbs[7].BackColor = System.Drawing.Color.Red;
                        break;
                    case 10:
                        form1.wirepbs[8].BackColor = System.Drawing.Color.Red;
                        break;
                    case 11:
                        form1.wirepbs[9].BackColor = System.Drawing.Color.Red;
                        break;
                    case 12:
                        form1.wirepbs[10].BackColor = System.Drawing.Color.Red;
                        break;
                    case 13:
                        form1.wirepbs[11].BackColor = System.Drawing.Color.Red;
                        break;
                    case 20:
                        form1.wirepbs[12].BackColor = System.Drawing.Color.Red;
                        break;
                    case 21:
                        form1.wirepbs[13].BackColor = System.Drawing.Color.Red;
                        break;
                    case 30:
                        form1.wirepbs[14].BackColor = System.Drawing.Color.Red;
                        break;
                    default:
                        throw new Exception();
                       
                
                }


            }
            else
            {
                on = true;
                switch (placed)
                {
                    case 0:
                        form1.wirepbs[0].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 1:
                        form1.wirepbs[1].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 2:
                        form1.wirepbs[2].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 3:
                        form1.wirepbs[3].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 4:
                        form1.wirepbs[4].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 5:
                        form1.wirepbs[5].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 6:
                        form1.wirepbs[6].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 7:
                        form1.wirepbs[7].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 10:
                        form1.wirepbs[8].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 11:
                        form1.wirepbs[9].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 12:
                        form1.wirepbs[10].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 13:
                        form1.wirepbs[11].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 20:
                        form1.wirepbs[12].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 21:
                        form1.wirepbs[13].BackColor = System.Drawing.Color.Blue;
                        break;
                    case 30:
                        form1.wirepbs[14].BackColor = System.Drawing.Color.Blue;
                        break;
                    default:
                        throw new Exception();


                }


            }






        }

    }
}
