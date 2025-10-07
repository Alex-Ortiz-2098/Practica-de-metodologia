using System;
using System.Collections.Generic;

namespace Practica
{
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> elementos;
        //constructor
        public Cola() { this.elementos = new List<Comparable>(); }
        //propiedades
        public List<Comparable> getElementosCola() { return elementos; }
        public void Agregar(Comparable c)
        { this.elementos.Add(c); }

        public List<Comparable> GetElementos()
        {
            return elementos;
        }


        //metodos propios de la cola


        public void desencolar()
        {
            if (Cuantos() > 0) { this.elementos.RemoveAt(0); }
            else { throw new Exception("Cola vacia"); }
        }

        //Implementacion los metodos de Coleccionable

        public int Cuantos() //Devuelve cauntos elementos hay en la Cola
        {
            return elementos.Count;
        }

        public Comparable Minimo() // Devuelve el elemento de MENOR valor
        {
            if (elementos.Count == 0)
            {
                return null;
            }

            Comparable min = null;
            foreach (Comparable c in elementos)
            {
                if (min == null || c.SosMenor(min))  //C pasara a ser this,valor mietras que MIN sera el casteado
                {
                    min = c;
                }
            }
            return min;
        }

        public Comparable Maximo() //  Devuelve el elemento de MAYOR valor
        {
            if (elementos.Count == 0)
                return null;

            Comparable max = null;
            foreach (Comparable c in elementos)
            {
                if (max == null || c.SosMayor(max)) //C pasara a ser this,valor mietras que MAX sera el casteado
                    max = c;
            }
            return max;
        }

        public bool Contiene(Comparable c)//  Agrega el elemento a a lista elementos
        {
            foreach (Comparable elem in elementos)
            {
                if (elem.SosIgual(c))
                    return true;
            }
            return false;
        }
        
        //Implemento la Interface Iterable

        public Iterador crearIterador()
        {
            return new IteradorDeCola(this);
        }
    }
}
