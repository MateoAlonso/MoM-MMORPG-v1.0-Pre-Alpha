using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    class Arco : Arma
    {
        private List<Flechas> flechas;

        public Arco(int baseDmg)
        {
            this.baseDmg = baseDmg;
            this.flechas = new List<Flechas>();
        }

        public override string ToString()
        {
            return this.GetType() + " Base dmg: " + this.baseDmg;
        }

        public override int usar()
        {
            throw new NotImplementedException();
        }
    }

}
