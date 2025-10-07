using System;
using System.Collections.Generic;

namespace Practica
{
    public class IteradorDeConjunto : Iterador
    {
        private int Posicion;
        private Conjunto ListaConjunto;

        public IteradorDeConjunto(Conjunto c)
        {
            this.ListaConjunto = c;
            primero();
        }
        public void primero()
        {
            Posicion = ListaConjunto.Cuantos() - 1;
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
                return ListaConjunto.GetElementos()[Posicion];
            }
            return null;
        }
    }
}