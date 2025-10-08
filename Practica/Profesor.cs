using System;
using System.Collections.Generic;

namespace Practica
{
    public class Profesor : Persona
    {
        private int antiguedad;
        private PoliticaDeComparacion politica = new PorAntiguedad();


        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.nombre = n;
            this.dni = d;
            this.antiguedad = a;
        }

        public int getAntiguedad() //Devuelve la variable nombre
        {
            return this.antiguedad;
        }

        public PoliticaDeComparacion POLITICA //devuelve y envia la Politica para hacer los cambios o imgresar por defecto
        {
            get { return politica; }
            set { politica = value; }
        }

        public override string ToString() //sirve para definir cómo se representa un objeto como texto
        {
            return "Nombre: " + nombre + ", Dni: " + dni + ", Antiguedad: " + antiguedad;
        }

        public void HablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
        }

        public void EscribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
        }

        //IMPLEMENTACION DE INTERFACE

        public override bool SosIgual(Comparable c) //Devuelve si es Igual atravez de un booleano usando una la Coleccion
        {
            Profesor aux = (Profesor)c;  // casteo
            return this.POLITICA.SosIgual(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMenor(Comparable c) //Devuelve si es Menor atravez de un booleano usando una la Coleccion 
        {
            Profesor aux = (Profesor)c;  // casteo
            return this.POLITICA.SosMenor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMayor(Comparable c) //Devuelve si es Mayor atravez de un booleano usando una la Coleccion
        {
            Profesor aux = (Profesor)c;  // casteo
            return this.POLITICA.SosMayor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        
    }
}