using System;
using System.Collections.Generic;

namespace Practica
{
    public class Conjunto : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        public List<Comparable> GetElementos()
        {
            return elementos;
        }

        public void Agregar(Comparable c)
        {
            // Solo agrego si NO está repetido
            if (!Contiene(c))
            {
                elementos.Add(c);
            }
        }

        public bool Contiene(Comparable c)
        {
            foreach (Comparable e in elementos)
            {
                if (e.SosIgual(c))
                    return true;
            }
            return false;
        }

        // Otros métodos de Coleccionable
        public int Cuantos()
        {
            return this.elementos.Count;
        }

        public Comparable Minimo()
        {
            Comparable min = elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.SosMenor(min))
                    min = e;
            }
            return min;
        }

        public Comparable Maximo()
        {
            Comparable max = elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.SosMayor(max))
                    max = e;
            }
            return max;
        }

        //Desde aqui implemento los metodos de Iterable

        public Iterador crearIterador()
        {
            return new IteradorDeConjunto(this);
        }


    }

} 