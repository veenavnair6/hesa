using System;
using System.Collections.Generic;
using System.Text;

namespace BeeLib
{
    public class WorkerBee : Bee
    {
        public override int DeathFactor
        {
            get
            {
                return 70;
            }
        }
    }
}
