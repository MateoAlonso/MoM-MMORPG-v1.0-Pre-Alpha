using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    
    class Flechas : Item
    {
        private readonly int dmg = 4;
        private int cant;

        public override string ToString()
        {
            return this.GetType() + " Base dmg: " + this.dmg + " Cant: " + this.cant;
        }

        public Flechas(int cant)
        {
            this.cant = cant;
        }

        
    }
}
