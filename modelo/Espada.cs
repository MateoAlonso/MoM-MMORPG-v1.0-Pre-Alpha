using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    class Espada : Arma
    {
        public Espada(int baseDmg)
        {
            this.baseDmg = baseDmg;
        }

        public override string ToString()
        {
            return this.GetType() + " Base dmg" + this.baseDmg;
        }

        public override int usar()
        {
            return this.baseDmg;
        }
    }
}
