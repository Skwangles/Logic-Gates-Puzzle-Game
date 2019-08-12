using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    class AndGate : Gate
    {
        public AndGate(Gate next, int outWireNum, PictureBox output) : base(next, outWireNum, 2, output)
        {
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;//Sets the called wire to the boolean of the called wire below
            next.ToggleLine((inputs[0] && inputs[1]), outWireNum);
            if (inputs[0] & inputs[1])
            {

                outputPb.BackgroundImage = Form1.WireImg[0];//Changes wire image based on state
            }
            else
            {
                outputPb.BackgroundImage = Form1.WireImg[1];
            }
        }
    }
}
