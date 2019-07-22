using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    abstract class Gate : Label 
    {
        public Gate(Gate next, int outWireNum, int numWires, PictureBox output) {
            this.next = next;
            this.outputPb = output;
            this.outWireNum = outWireNum;
            this.inputs = new bool[numWires];
        }
        public PictureBox outputPb;
        public Gate next;
        public int outWireNum;
        public bool[] inputs;

        public abstract void ToggleLine(bool on, int wire);

       
    }
}
