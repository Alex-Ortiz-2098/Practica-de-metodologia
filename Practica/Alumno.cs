using System;
using System.Collections.Generic;

namespace Practica
{
    public class Alumno : Persona
    {
        private int legajo;
        private int promedio;
        private PoliticaDeComparacion politica;
        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int getlegajo() //Devuelve la variable nombre
        {
            return this.legajo;
        }

        public int getPromedio() //Devuelve la variable dni
        {
            return this.promedio;
        }

        public PoliticaDeComparacion POLITICA //devuelve y envia la Politica para hacer los cambios o imgresar por defecto
        {
             get { return politica; }    
             set { politica = value; }
        }


        public override string ToString() //sirve para definir cómo se representa un objeto como texto
        {
            return "Nombre: "+nombre+", Dni: "+dni+", Legajo: " +legajo+", Promedio: "+promedio;
;
        }

        //IMPLEMENTACION DE INTERFACE

        public override bool SosIgual(Comparable c) //Devuelve si es Igual atravez de un booleano usando una la Coleccion
        {
            Alumno aux = (Alumno)c;  // casteo
            return this.POLITICA.SosIgual(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMenor(Comparable c) //Devuelve si es Menor atravez de un booleano usando una la Coleccion 
        {
            Alumno aux = (Alumno)c;  // casteo
            return this.POLITICA.SosMenor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMayor(Comparable c) //Devuelve si es Mayor atravez de un booleano usando una la Coleccion
        {
            Alumno aux = (Alumno)c;  // casteo
            return this.POLITICA.SosMayor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

    }
}