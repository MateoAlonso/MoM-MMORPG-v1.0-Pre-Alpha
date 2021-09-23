using System;
using System.Collections.Generic;
using System.Text;

namespace MoM.vista
{
    class VistaConsola : Vista
    {
        
        public void iniciar()
        {
            Console.WriteLine("Bienvenido a MoM!");
        }

        public void menuPrincipal() {
            Console.WriteLine("Ingrese una opcion: \n 1. Crear personaje \n 2. Agregar item \n 3. Atacar \n 4. Usar item \n 5. Ver personajes \n 6. Ver items de personaje \n 7. Salir");
        }

        public void mostrarLista<T> (List<T> lista) {
            int i = 0;
            foreach (var item in lista)
            {
                Console.WriteLine(i + ". " + item);
                i++;
            }
        }

        public void mostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public void menuCreacionItem()
        {
            Console.WriteLine("Eliga un personaje y el item a agregar: \n 1. Hacha \n 2. Espada \n 3. Arco \n 4. Flechas \n 5. Comida");
        }


    }
}
