using System;
using System.Collections.Generic;
using System.Text;

namespace BeeLib
{
    public class QueenBee : Bee
    {
        public override int DeathFactor
        {
            get
            {
                return 20;
            }
        }
    }
}
