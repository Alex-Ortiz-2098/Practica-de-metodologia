using System;
using System.Collections.Generic;

namespace Practica
{
    public class Alumno : Persona, Comparable,  Observador, IAlumno
    {
        private int legajo;
        private int promedio;
        private PoliticaDeComparacion politica = new PorNombre();

        private int Calificacion;
        public Alumno(string n, string a, int d, int l, int p) : base(n, a, d)
        {
            this.legajo = l;
            this.promedio = p;
        }

        public override string getNombre() //Devuelve la variable nombre
        {
            return this.nombre;
        }
        public override string getApellido() //Devuelve la variable nombre
        {
            return this.Apellido;
        }


        public override int getDNI() //Devuelve la variable dni
        {
            return this.dni;
        }

        public int getlegajo() //Devuelve la variable Legajo
        {
            return this.legajo;
        }

        public int getPromedio() //Devuelve la variable Promedio
        {
            return this.promedio;
        }

        public int getCalificacion() //devuelve la Calificacion del Alumno
        {
            return this.Calificacion;

        }

        public void setCalificacion(int cal)
        {
            this.Calificacion = cal; 
        }

        public PoliticaDeComparacion POLITICA //devuelve y envia la Politica para hacer los cambios o imgresar por defecto
        {
             get { return politica; }    
             set { politica = value; }
        }

        public override string ToString() //sirve para definir cómo se representa un objeto como texto
        {
            return "Nombre: "+nombre+"Nombre: "+Apellido+", Dni: "+dni+", Legajo: " +legajo+", Promedio: "+promedio;
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

        public virtual int  responderPregunta(int pregunta) 
        {
            Random rand = new Random();
            return rand.Next(1, 4); // retorna 1, 2 o 3
        }

        public string mostrarCalificacion()
        {
            return ("Nombre y Apellido: " + nombre + " " + Apellido + ", Ultima Calificacion: " + Calificacion);
        }

        /*IMPLEMENTACION DE INTERFACE
        ANTIGUAMENTE utilizaba ALUMNO como casteo pero a raiz de tener que hacr los decoreitor empece a trabajar los casteos
        con IAlumno (INTERFACE ALUMNO)*/

        public override bool SosIgual(Comparable c) //Devuelve si es Igual atravez de un booleano usando una la Coleccion
        {
            IAlumno aux = (IAlumno)c;  // casteo
            return this.POLITICA.SosIgual(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMenor(Comparable c) //Devuelve si es Menor atravez de un booleano usando una la Coleccion 
        {
            IAlumno aux = (IAlumno)c;  // casteo
            return this.POLITICA.SosMenor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        public override bool SosMayor(Comparable c) //Devuelve si es Mayor atravez de un booleano usando una la Coleccion
        {
            IAlumno aux = (IAlumno)c;  // casteo
            return this.POLITICA.SosMayor(this, aux);  // Dirige la funcion a Politica de comparacion con la politica indicada
        }

        //IMPLEMENTACION DE LA INTERFACE OBERSERVADOR

        public void Actualizar(Observado o)
        {
            if (((Profesor)o).getHablando())
            {
                this.PrestarAtencion();
            }
            else { this.Distraerse(); }
        }

        

    }
}