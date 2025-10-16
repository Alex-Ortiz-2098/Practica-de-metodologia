using System;
using System.Collections.Generic;

namespace Practica
{
    public class Pila : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementos;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;
        // Constructor

        public Pila()
        {
            this.elementos = new List<Comparable>();
        }
        //propiedades

        public List<Comparable> GetElementos()
        {
            return elementos;
        }

        public void Apilar(Comparable c) { this.elementos.Add(c); }
        //cuantos retorna la cantidad de elementos que tiene la pila
        public bool Contiene(Comparable c)
        {
            if (this.Cuantos() > 0)
            {
                foreach (Comparable elem in this.elementos)
                {
                    if (elem.SosIgual(c)) { return true; }
                }
                return false;
            }
            return false;
        }
        public Comparable desapilar()
        {
            if (Cuantos() > 0)
            {
                Comparable elemento = this.elementos[this.Cuantos() - 1];
                this.elementos.RemoveAt(this.Cuantos() - 1);
                return elemento;
            }
            return null;
        }

        // IMPLEMENTACION DE ORDENABLE

        public void setOrdenInicio(IOrdenEnAula1 orden)
        {
            ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
        {
            ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 orden)
        {
            ordenAulaLlena = orden;
        }


        //  Implementacion de interface Coleccionable

        public int Cuantos()//  Devuelve la cantidad de elementos en la pila
        {
            return elementos.Count;
        }

        public Comparable Minimo() //  Devuelve el elemento de MENOR valor
        {
            if (elementos.Count == 0)
            {
                return null;
            }

            Comparable min = null;
            foreach (Comparable c in elementos)
            {
                if (min == null || c.SosMenor(min))  //C pasara a ser this,valor mietras que MIN sera el casteado
                    min = c;
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

        public void Agregar(Comparable c)//  Agrega el elemento a a lista elementos
        {
            // Si es el primer elemento → ejecutar OrdenInicio
            if (Cuantos() == 0 && ordenInicio != null)
            ordenInicio.Ejecutar();

            // Siempre que llegue un elemento → ejecutar OrdenLlegaAlumno
            if (ordenLlegaAlumno != null)
            ordenLlegaAlumno.Ejecutar(c);

            // Agregar el elemento a la pila
            elementos.Add(c);

            // Si ahora la pila tiene 40 → ejecutar OrdenAulaLlena
            if (Cuantos() == 40 && ordenAulaLlena != null)
            ordenAulaLlena.Ejecutar();
           
        }//MODIFICACION CON LAS ORDENES

        //Implemento la Interface Iterable

        public Iterador crearIterador()
        {
            return new IteradorDePila(this);
        }

    }
}
