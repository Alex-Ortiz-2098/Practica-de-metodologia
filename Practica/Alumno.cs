using System;
using System.Collections.Generic;

namespace Practica
{
    public class Alumno : Persona, Observador
    {
        private int legajo;
        private int promedio;
        private PoliticaDeComparacion politica = new PorNombre();
        public Alumno(string n, int d, int l, int p) : base(n, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public int getlegajo() //Devuelve la variable Legajo
        {
            return this.legajo;
        }

        public int getPromedio() //Devuelve la variable Promedio
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

        public void PrestarAtencion()
        {
            Console.WriteLine("Prestando atención");
        }

        public void Distraerse()
        {
            //Elegiendo frase de manera ramdon
            Random rand = new Random();
            string[] distracciones = ["Mirando celular", "Dibujando en el margen de la carpeta", "tirando aviones de papel"];
            Console.WriteLine(distracciones[rand.Next(0, 2)]);
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

        //IMPLEMENTACION DE LA INTERFACE OBERSERVADOR

        public void Actualizar(Observado o)
        {
            if (((Profesor)o).getHablando())
            {
                this.PrestarAtencion();
            }
            else{ this.Distraerse(); }
        }

    }
}