using System;
using System.Collections.Generic;

namespace Practica
{
    /*Usando IAlumno, cualquier clase que implemente la interfaz puede ser decorada, 
    la cadena de decoradores funciona sin importar la clase concreta.*/
    public abstract class DecoradorAlumno : IAlumno
    {
        protected IAlumno alumno;

        public DecoradorAlumno(IAlumno a)
        {
            this.alumno = a;
        }

        public virtual string mostrarCalificacion()
        {
            return alumno.mostrarCalificacion();
        }

        public string getNombre()
        { return this.alumno.getNombre(); } 

        public int getDNI()
        {
            return this.alumno.getDNI();
        }
        
        public string getApellido() //Devuelve la variable nombre
        {
            return this.alumno.getApellido();
        }

        public int getlegajo()
        {return alumno.getlegajo();}
        public int getPromedio()
        {return alumno.getPromedio();}
        public int getCalificacion()
        {return alumno.getCalificacion();}
        public void setCalificacion(int cal)
        { alumno.setCalificacion(cal);}
        public int responderPregunta(int pregunta)
        { return alumno.responderPregunta(pregunta); }

        public PoliticaDeComparacion POLITICA
        {
            get { return this.alumno.POLITICA; }    
             set { this.alumno.POLITICA = value; }
        }

        public bool SosIgual(Comparable c)
        {
           return alumno.SosIgual(c);
        }
        public bool SosMenor(Comparable c)
        {
            return alumno.SosMenor(c); 
        }
        public bool SosMayor(Comparable c)
        {
            return alumno.SosMayor(c);
        }
    }

}
