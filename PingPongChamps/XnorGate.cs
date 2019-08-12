using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    class XnorGate : Gate
    {
        public XnorGate(Gate next, int outWireNum, PictureBox output) : base(next, outWireNum, 2, output)
        {
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            next.ToggleLine((inputs[0] && inputs[1]) || (inputs[0] == false && inputs[1] == false), outWireNum);
            if ((inputs[0] && inputs[1]) || (inputs[0] == false && inputs[1] == false))
            {               
                outputPb.BackgroundImage = Form1.wireImg[0];
            }
            else {
                outputPb.BackgroundImage = Form1.wireImg[1];
            }
        }
    }
}
