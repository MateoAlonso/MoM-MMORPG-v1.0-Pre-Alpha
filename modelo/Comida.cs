using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    class Comida : Item, Usable
    {
        private readonly int curacion;
        private int usos;

        public override string ToString()
        {
            return this.GetType() + " Usos: " + this.usos + " Curacion: " + this.curacion;
        }

        public Comida(int curacion, int usos)
        {
            this.curacion = curacion;
            this.usos = usos;
        }

        public int usar()
        {
            if (this.usos > 0)
            {
                this.usos--;
                return this.curacion;
            }
            return 0;
        }
    }
}
