using System;
using System.Collections.Generic;

namespace Practica
{
    public class IteradorDePila : Iterador
    {
        private int Posicion;
        private Pila ListaPila;

        public IteradorDePila(Pila p)
        {
            this.ListaPila = p;
            primero();
        }
        public void primero()
        {
            Posicion = ListaPila.Cuantos() - 1;
        }

        public void siguiente()
        {
            Posicion--;
        }

        public bool fin()
        {
            return Posicion < 0;
        }

        public Comparable actual()
        {
            if (!fin())
            {
                return ListaPila.GetElementos()[Posicion];
            }
            return null;
        }
    }
}