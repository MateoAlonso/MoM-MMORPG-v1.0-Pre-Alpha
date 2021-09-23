using System;
using System.Collections.Generic;
using System.Text;

namespace MoM
{
    abstract class Item
    {
        
        public void equipar(Personaje pj) {
            pj.agregarItem(this);
        }

    }
}
