using System;
using System.Collections.Generic;

namespace Practica
{
    public class Profesor : Persona, Observado
    {
        private int antiguedad;

        private PoliticaDeComparacion politica = new PorAntiguedad();

        private List<Observador> AlumnosObservados; // Lista de alumnos para poder actualizar 

        private bool Hablando; 
        
        public Profesor(string n, int d, int a) : base(n, d)
        {
            this.nombre = n;
            this.dni = d;
            this.antiguedad = a;
            this.AlumnosObservados = new List<Observador>();
        }

        public int getAntiguedad() //Devuelve la variable nombre
        {
            return this.antiguedad;
        }

        public bool getHablando()
        { 
            return this.Hablando; 
            
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
            Hablando = true;
            Console.WriteLine("Hablando de algún tema");
            Notificar();
        }

        public void EscribirEnElPizarron()
        {
            Hablando = false;
            Console.WriteLine("Escribiendo en el pizarrón");
            Notificar();

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

        //IMPLEMENTAMOS LOS METODOS DE OBSERVADO

        public void AgregarObservador(Observador o)
        {
            AlumnosObservados.Add(o);
        }

        public void QuitarObservador(Observador o)
        {
            AlumnosObservados.Remove(o);
        }

        public void Notificar()
        {
            foreach (Observador aux in AlumnosObservados)
            {
                aux.Actualizar(this);
            }
        }

        

    }
}