using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MoM.controlador
{
    class Controlador
    {
        private List<Personaje> personajes;
        private vista.Vista vista;

        public Controlador(vista.Vista vista)
        {
            this.personajes = new List<Personaje>();
            this.vista = vista;
            vista.iniciar();
            inicio();
        }

        private void inicio() {
            vista.menuPrincipal();
            int opcion = readLineInt();
            switch (opcion)
            {
                case 1:
                    vista.mostrarMensaje("Ingrese vida maxima y nombre");
                    crearPersonje(readLineInt(), Console.ReadLine());
                    break;
                case 2:
                    vista.menuCreacionItem();
                    selectItemCrear(readLineInt(), readLineInt());
                    break;
                case 3:
                    vista.mostrarMensaje("Eliga personaje atacante,  personaje atacado y arma");
                    atacar(readLineInt(), readLineInt(), readLineInt());
                    break;
                case 4:
                    vista.mostrarMensaje("Ingrese Personaje y comida");
                    comer(readLineInt(), readLineInt());
                    break;
                case 5:
                    mostrarPjs();
                    break;
                case 6:
                    vista.mostrarMensaje("Ingrese el personaje para ver sus items");
                    mostrarItems(readLineInt());
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            inicio();
            
        }

        private void selectItemCrear(int pj, int opcion) {

            switch (opcion)
            {
                case 1:
                    vista.mostrarMensaje("Ingrese crit chance y dano base");
                    agregarHacha(pj, readLineInt(), readLineInt());
                    break;
                case 2:
                    vista.mostrarMensaje("Ingrese dano base");
                    agregarEspada(pj, readLineInt());
                    break;
                case 3:
                    vista.mostrarMensaje("Ingrese dano base");
                    agregarArco(pj, readLineInt());
                    break;
                case 4:
                    vista.mostrarMensaje("Ingrese cantidad");
                    agregarFlechas(pj, readLineInt());
                    break;
                case 5:
                    vista.mostrarMensaje("Ingrese curacion y usos");
                    agregarComida(pj, readLineInt(), readLineInt());
                    break;
                case 6:
                    vista.mostrarMensaje("Ingrese defensa");
                    agregarArmadura(pj, readLineInt());
                    break;
                default:
                    break;
            }
        }
        private int readLineInt() {
            return Convert.ToInt32(Console.ReadLine());
        }
       
        public void crearPersonje(int vidaMax, String nombre) {
            this.personajes.Add(new Personaje(vidaMax, nombre));
        }

        public void agregarComida(int index, int curacion, int usos) {
            buscarPj(index).agregarItem(new Comida(curacion, usos));
        }
        public void agregarHacha(int index, float critChance, int baseDmg ) {
            buscarPj(index).agregarItem(new Hacha(critChance, baseDmg));
        }

        public void agregarFlechas(int index, int cant)
        {
            buscarPj(index).agregarItem(new Flechas(cant));
        }

        public void agregarArco(int index, int baseDmg)
        {
            buscarPj(index).agregarItem(new Arco(baseDmg));
        }

        public void agregarEspada(int index, int baseDmg)
        {
            buscarPj(index).agregarItem(new Espada(baseDmg));
        }

        public void agregarArmadura(int index, int defensa)
        {
            buscarPj(index).agregarItem(new Armadura(defensa));
        }

        private Personaje buscarPj(int index) {
            return this.personajes.ElementAt(index);
        }

        public void mostrarPjs() {
            List<String> pjsInfo = new List<String>();
            foreach (var item in this.personajes)
            {
                pjsInfo.Add(item.ToString());
            }
            vista.mostrarMensaje("Los personajes son: \n");
            vista.mostrarLista(pjsInfo);
        }

        public void mostrarItems(int index) {
            Personaje pj = buscarPj(index);
            List <String> items = pj.verItems();
            vista.mostrarMensaje("Los items de " + pj.getNombre() + " son: \n");
            vista.mostrarLista(items);
        }

        public void atacar(int indexAtacante, int indexAtacado, int indexArma) {
            Personaje atacante = buscarPj(indexAtacante);
            Personaje atacado = buscarPj(indexAtacado);
            try
            {
                atacante.atacar(atacado, indexArma);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }

        public void comer(int indexPj, int indexItem) {
            Personaje pj = buscarPj(indexPj);
            try
            {
                pj.comer(indexItem);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
