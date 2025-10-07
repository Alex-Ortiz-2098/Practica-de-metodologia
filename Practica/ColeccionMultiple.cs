using System;
using System.Collections.Generic;

namespace Practica
{
    public class ColeccionMultiple : Coleccionable
    {
        private Pila ListPila;
        private Cola ListCola;

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.ListPila = p;
            this.ListCola = c;
        }

        public void Agregar(Comparable c)
        {}

        public bool Contiene(Comparable c)
        {
            if (this.Cuantos() > 0)
            {
                foreach (Comparable elem in this.ListPila.GetElementos())
                {
                    if (elem.SosIgual(c))
                    {
                        return true;
                    }
                }
                 foreach (Comparable elem in this.ListCola.GetElementos())
                {
                    if (elem.SosIgual(c))
                    {
                        return true;
                    }
                }
                
            }
            return false;
        }

        public int Cuantos()
        {
            return ListCola.Cuantos() + ListPila.Cuantos();
        }


        public Comparable? Maximo()
        {
            if (this.Cuantos() == 0)
            {
                return null;
            }
            Comparable x = (Comparable)this.ListPila.Maximo();
            Comparable y = (Comparable)this.ListCola.Maximo();
            if (x.SosMayor(y))
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        public Comparable? Minimo()
        {
            if (this.Cuantos() == 0)
            {
                return null;
            }
            Comparable x = (Comparable)this.ListPila.Minimo();
            Comparable y = (Comparable)this.ListCola.Minimo();
            if (x.SosMenor(y))
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}