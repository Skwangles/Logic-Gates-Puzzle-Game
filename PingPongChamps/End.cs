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

        public End(Form1 form1) : base(null, 0, 2, null)
        {
            this.form1 = form1;
        }
        bool on;
        public override void ToggleLine(bool on, int wire)
        {
            this.on = on;
            this.inputs[wire] = on;
            if (on && form1.gamestart)
            {
                //needs current open form1 instance to call .wincondition
                form1.Winner();
            }
            else if (on)
            {
                

            }


            //end game here - code not yet placed
        }

        public bool StillOn()
        {
            if (on)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
