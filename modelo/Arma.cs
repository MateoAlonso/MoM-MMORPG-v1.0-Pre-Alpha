using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    abstract class Arma : Item, Usable
    {
        protected int baseDmg;

        public int getDmg() {
            return this.baseDmg;
        }

        public abstract int usar();
    }
}
