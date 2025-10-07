using System;
using System.Collections.Generic;

namespace Practica
{
    public class IteradorDeCola : Iterador
    {
        private int Posicion;
        private Cola ListaCola;

        public IteradorDeCola(Cola c)
        {
            this.ListaCola = c;
            primero();
        }
        public void primero()
        {
            Posicion = ListaCola.Cuantos() - 1;
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
                return ListaCola.GetElementos()[Posicion];
            }
            return null;
        }
    }
}