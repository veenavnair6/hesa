using System;

namespace BeeLib
{
    public abstract class Bee
    {
        public decimal Health { get; private set; }

        public abstract int DeathFactor { get; }

        public bool Dead
        {
            get
            {
                return Health < DeathFactor;
            }
        }
        public Bee()
        {
            Health = 100;
        }

        public void Damage(int dmgper)
        {
            if (!Dead)
                Health = Math.Round(Health - ((decimal)dmgper / 100) * Health, 2);
        }
    }
}
