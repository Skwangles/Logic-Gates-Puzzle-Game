using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongChamps
{
    class XnorGate : Gate
    {
        public XnorGate(Gate next, int outWireNum) : base(next, outWireNum, 2)
        {
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            next.ToggleLine((inputs[0] && inputs[1]) || (inputs[0] == false && inputs[1] == false), outWireNum);
        }
    }
}
