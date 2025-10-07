using System;
using System.Collections.Generic;

namespace Practica
{
    public class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona(string n, int d)
        {
            this.nombre = n.ToLower();
            this.dni = d;

        }

        public string getNombre() //Devuelve la variable nombre
        {
            return this.nombre;
        }


        public int getDNI() //Devuelve la variable dni
        {
            return this.dni;
        }

         public override string ToString()
        {
            return dni.ToString();
        }

        //IMPLEMENTACION DE INTERFACE

        public virtual bool SosIgual(Comparable c) //Devuelve si es Igual atravez de un booleano usando un legajo
        {
            Persona aux = (Persona)c;  // casteo
            return this.nombre == aux.nombre;
        }

        public virtual bool SosMenor(Comparable c) //Devuelve si es Igual atravez de un booleano usando un legajo
        {
            Persona aux = (Persona)c;  // casteo
            return this.dni < aux.dni;
        }

        public virtual bool SosMayor(Comparable c) //Devuelve si es Igual atravez de un booleano usando un legajo
        {
            Persona aux = (Persona)c;  // casteo
            return this.dni > aux.dni;
        }
        
    }
}