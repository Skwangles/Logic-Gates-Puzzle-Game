using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongChamps
{
    abstract class Gate
    {
        public Gate(Gate next, int outWireNum, int numWires) {
            this.next = next;
            this.outWireNum = outWireNum;
            this.inputs = new bool[numWires];
        }

        public Gate next;
        public int outWireNum;
        public bool[] inputs;

        public abstract void ToggleLine(bool on, int wire);
    }
}
