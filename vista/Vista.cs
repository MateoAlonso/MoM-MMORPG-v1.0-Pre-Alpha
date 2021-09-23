using System;
using System.Collections.Generic;
using System.Text;

namespace MoM.vista
{
    interface Vista
    {
        public void iniciar();

        public void menuPrincipal();

        public void mostrarLista<T>(List<T> lista);

        public void mostrarMensaje(String mensaje);

        public void menuCreacionItem();
    }
}
