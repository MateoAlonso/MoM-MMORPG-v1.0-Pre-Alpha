using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    class Hacha : Arma
    {
        private readonly float critChance;

        public Hacha(float critChance, int baseDmg)
        {
            this.critChance = critChance;
            this.baseDmg = baseDmg;
        }

        public override string ToString()
        {
            return this.GetType() + " Base dmg: " + this.baseDmg + " Crit chance: " + this.critChance;
        }

        private int getDmg() {
            return esCrit() ? this.baseDmg * 2 : this.baseDmg;
        }

        private Boolean esCrit() {
            return true;
        }

        public override int usar()
        {
            return this.getDmg();
        }
    }
}
