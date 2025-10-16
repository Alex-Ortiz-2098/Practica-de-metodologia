using System;
using System.Collections.Generic;

namespace Practica
{
    public class Cola : Coleccionable, Iterable, Ordenable
    {
        private List<Comparable> elementos;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena;

        //constructor
        public Cola() { this.elementos = new List<Comparable>(); }
        
        //propiedades
        public List<Comparable> getElementosCola() { return elementos; }

        public void Agregar(Comparable c)
        {
            // Si es el primer elemento → ejecutar OrdenInicio
            if (Cuantos() == 0 && ordenInicio != null)
            ordenInicio.Ejecutar();

            // Siempre que llegue un elemento → ejecutar OrdenLlegaAlumno
            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.Ejecutar(c);

            // Agregar el elemento al final de la cola
            elementos.Add(c);

            // Si ahora la cola tiene 40 → ejecutar OrdenAulaLlena
            if (Cuantos() == 40 && ordenAulaLlena != null)
                ordenAulaLlena.Ejecutar();
        
        }//MODIFICACION CON LAS ORDENES

        public List<Comparable> GetElementos()
        {
            return elementos;
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
