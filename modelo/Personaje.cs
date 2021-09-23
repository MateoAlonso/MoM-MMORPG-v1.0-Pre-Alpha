using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MoM
{
    class Personaje
    {
        private EstadoSalud estado;
        private int vidaMax;
        private int vida;
        private List<Item> items;
        private String nombre;
        public Personaje(int vidaMax, String nombre) {
            this.vidaMax = vidaMax;
            this.vida = vidaMax;
            this.estado = EstadoSalud.vivo;
            this.items = new List<Item>();
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + " Vida: " + this.vida + "/" + this.vidaMax + " Estado de salud: " + this.estado;
        }

        public void agregarItem(Item item) {
            this.items.Add(item);
        }

        public int getVidaMax() {
            return this.vidaMax; 
        }

        public int getVida() {
            return this.vida;
        }

        public List<String> verItems() {
            List<String> itemsReturn = new List<String>();
            foreach (var item in this.items)
            {
                itemsReturn.Add(item.ToString());
            }
            return itemsReturn;
        }

        private int usarItem(Item item) {
            int r = 0;
            
            if (item is Usable)
            {
                Usable itemUsar = (Usable)item;
                r = itemUsar.usar();
            }
            else
            {
                throw new InvalidCastException("El item no es usable");
            }
            return r;
            
        }

        private Item buscarItem(int index) {
            return this.items.ElementAt(index);
        }

        public void atacar(Personaje personaje, int index) {
            
            int ataque = usarItem(buscarItem(index));
            if (this.estado == EstadoSalud.herido)
            {
                ataque /= 2;
            }
            personaje.restarVida(ataque);
            
        }

        public void comer(int index) {
            sumarVida(usarItem(buscarItem(index)));
        }

        public void restarVida(int vidaARestar) {
            foreach (var item in this.items)
            {
                if (item is Armadura)
                {
                    Armadura a = (Armadura)item;
                    vidaARestar -= a.getDef();
                    break;
                }
            }
            this.vida -= vidaARestar;
            actualizarEstadoSalud();
        }

        public void sumarVida(int vidaASumar) {
            this.vida = this.vida + vidaASumar;
            actualizarEstadoSalud();
        }

        public void actualizarEstadoSalud() {
            if (this.vida <= 0) {
                this.estado = EstadoSalud.muerto;
            } else {
                if (this.vida < this.vidaMax / 2) {
                    this.estado = EstadoSalud.herido;
                } else {
                    this.estado = EstadoSalud.vivo;
                }
            }
        }

        public Boolean estaMuerto() {
            if (this.estado == EstadoSalud.muerto) {
                return true;
            }
            return false;
        }

        public String getNombre() {
            return this.nombre;
        }
    }
    
}
