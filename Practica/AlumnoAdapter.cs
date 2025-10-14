using System;
using System.Collections.Generic;

namespace Practica
{

    public class AlumnoAdapter : Student, Comparable
    {
        private IAlumno alumno;   // referencia al IAlumno
        //Recibiendo un IAlumno, puede adaptarse cualquier implementación que cumpla la interfaz, incluyendo decoradores.

        public AlumnoAdapter(IAlumno a)
        {
            this.alumno = a;
        }

        public string getName()
        {
            return this.alumno.getNombre(); // Retorna el nombre 
        }

        public int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            this.alumno.setCalificacion(score); // Remplaza la calificacion
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            AlumnoAdapter otro = (AlumnoAdapter)student;
            return alumno.SosIgual(otro.alumno);
        }

        public bool lessThan(Student student)
        {
            AlumnoAdapter otro = (AlumnoAdapter)student;
            return alumno.SosMenor(otro.alumno);
        }

        public bool greaterThan(Student student)
        {
            AlumnoAdapter otro = (AlumnoAdapter)student;
            return alumno.SosMayor(otro.alumno);
        }

        /*Aunque inplicitamente adapatamos las funciones de comparable, a la hora de hacer la fabrica de student es necesario
        agregar los metodos aunque no sean usados para poder hacer la conversion en la fabrica correctamente*/

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