using System;
using System.Collections.Generic;

namespace Practica
{
    public class Aula
    {
        private Teacher Teacher;

        public void Comenzar()
        {
            Console.WriteLine("Comenzamossssssssssss");
            Teacher = new Teacher();

        }

        public void NuevoAlumno(Alumno a)
        { 
            /*LLama a la funcion que DecorarAlumnos para Ver sus Calificaciones asi como lo haciaStudentsFactory y/o StudentsMuyEstudiososFactory*/
            IAlumno alumnoDecorado = DecorarAlumno(a); 
            Student Aux = new AlumnoAdapter(alumnoDecorado);
            Teacher.goToClass(Aux);
        }

        public void ClaseLista()
        {
            Console.WriteLine("Ya Estamos todossss");
            Teacher.teachingAClass();
        }

        private IAlumno DecorarAlumno(Alumno a)
        {
            /*Los Alumnos deben ser Decorados dentro de la CLASE Aula porque la funcion NuevoAlumno se le 
            pasa como parametro un Alumno(No un IAlumno), lo que me dificultaba pasarle un decorado*/
            IAlumno alumnoDecorado = new DecoPorLegajo(a);
            alumnoDecorado = new DecoCalificacionLetras(alumnoDecorado);
            alumnoDecorado = new DecoPorNotaP(alumnoDecorado);
            alumnoDecorado = new DecoPorAsterisco(alumnoDecorado);
            return alumnoDecorado;
        }
    
    
    
    }
}