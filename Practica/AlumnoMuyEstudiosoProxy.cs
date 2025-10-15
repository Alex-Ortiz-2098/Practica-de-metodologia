using System;
using System.Collections.Generic;

namespace Practica
{
    public class AlumnoMuyEstudiosoProxy : IAlumnoMuyEstudioso
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected int legajo;
        protected int promedio;
        protected int calificacion;
        protected PoliticaDeComparacion politica = new PorNombre();

        //Referencia al objeto real. Comienza como null.
        private IAlumnoMuyEstudioso alumnoReal = null;

        public AlumnoMuyEstudiosoProxy(string n, string a, int d, int l, int p)
        {
            this.nombre = n;
            this.apellido = a;
            this.dni = d;
            this.legajo = l;
            this.promedio = p;
        }

        public string getNombre() { return this.nombre; }
        public string getApellido() { return this.apellido; }
        public int getDNI() { return this.dni; }
        public int getlegajo() { return this.legajo; }
        public int getPromedio() { return this.promedio; }
        public int getCalificacion()
        {
            if (alumnoReal != null)
            {
                return alumnoReal.getCalificacion();
            } 
            return -1; // SI aparece este numero se da por entendido de que no exite calificacion
        }
        public void setCalificacion(int cal)
        {
            if (alumnoReal != null)
            {
                alumnoReal.setCalificacion(cal);

            }
        }

        public PoliticaDeComparacion POLITICA
        {
            get { return this.politica; }
            set { this.politica = value; }
        }

        public int responderPregunta(int pregunta)
        {
            // Si el alumno real no existe aún, se crea ahora
            if (alumnoReal == null)
            {
                Console.WriteLine("CREO UN ALUMNO MUY ESTUDIOSO");
                alumnoReal = new AlumnoMuyEstudioso(nombre, apellido, dni, legajo, promedio);

                alumnoReal.POLITICA = this.politica;
            }

            // Luego se delega la llamada
            return alumnoReal.responderPregunta(pregunta);
        }

        public string mostrarCalificacion()
        {
            if (alumnoReal != null)
            {
                return alumnoReal.mostrarCalificacion();

            }
            return ("Nombre y Apellido: " + nombre + " " + apellido + ", no ah sido Calificado");
        }

        public bool SosIgual(Comparable c)
        {
            if(alumnoReal != null)
            {
                return alumnoReal.POLITICA.SosIgual(alumnoReal,c);
            }
            return POLITICA.SosIgual(this, c); 
        
        }

        public bool SosMenor(Comparable c)
        {
            if(alumnoReal != null)
            {
                return alumnoReal.POLITICA.SosMenor(alumnoReal,c);
            }
            return POLITICA.SosMenor(this, c);
        }

        public bool SosMayor(Comparable c)
        {
            if(alumnoReal != null)
            {
                return alumnoReal.POLITICA.SosMayor(alumnoReal,c);
            }
            return POLITICA.SosMayor(this, c);
        }
        
    }
}

        