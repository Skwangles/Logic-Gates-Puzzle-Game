﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    class NorGate : Gate
    {
        public NorGate(Gate next, int outWireNum, PictureBox output) : base(next, outWireNum, 2,output)
        {
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            next.ToggleLine((inputs[0] || inputs[1]) ? false : true , outWireNum);
            if (inputs[0] || inputs[1])
            {   
                outputPb.BackgroundImage = Form1.wireImg[1];
            }
            else
            {
                outputPb.BackgroundImage = Form1.wireImg[0];
            }
        }
    }
}
