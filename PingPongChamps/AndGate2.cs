using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{//this Class Is not being used

    class AndGate2 : Gate
    {
        public AndGate2(Gate next, int outWireNum, PictureBox output ) : base(next, outWireNum, 2, output)
        {
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            next.ToggleLine((inputs[0] && inputs[1])? true : false, outWireNum);
            if (inputs[0] & inputs[1])
            {

                outputPb.BackColor = System.Drawing.Color.Blue;
            }
            else
            {
                outputPb.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
