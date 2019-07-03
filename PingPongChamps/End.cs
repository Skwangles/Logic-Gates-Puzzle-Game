﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongChamps
{
    class End : Gate
    {
        private Form1 form1;
       
        public End(Form1 form1) : base(null, 0, 2)
        {
            this.form1 = form1;
        }

        public override void ToggleLine(bool on, int wire)
        {
            this.inputs[wire] = on;
            if (on)
            {
                //needs current open form1 instance to call .wincondition
                form1.Winner();
            }
            else
            {
                
            }
            //end game here - code not yet placed
        }
    }
}
