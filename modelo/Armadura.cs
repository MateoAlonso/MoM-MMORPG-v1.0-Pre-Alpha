using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    class Armadura : Item
    {
        private readonly int def;

        public Armadura(int def)
        {
            this.def = def;
        }

        public int getDef() {
            return this.def;
        }

        public override string ToString()
        {
            return this.GetType() + " Defensa: " + this.def;
        }
    }
}
