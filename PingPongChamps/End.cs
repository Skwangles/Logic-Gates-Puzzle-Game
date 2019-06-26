using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongChamps
{
    class End : Gate
    {
        public static int A;
        public End(Gate next, int outWireNum) : base(next, outWireNum, 2)
        {
            
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            if (on)
            {
               //needs current open form1 instance to call .wincondition
                
            }
            else
            {
                
            }
            //end game here - code not yet placed
        }
    }
}
