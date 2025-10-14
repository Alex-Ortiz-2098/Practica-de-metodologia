using System;
using System.Collections.Generic;

namespace Practica
{
    public class StudentsMuyEstudiososFactory : FabricaDeAlumnosMuyEstudiosos
    {
        //Este método crea un Student aleatorio, decorado y adaptado
        public override Comparable crearAleatorio()
        {
           AlumnoMuyEstudioso alumnoBase = (AlumnoMuyEstudioso)base.crearAleatorio(); //Casteeamos al AlumnoEstudioso base dirigido de FabricaDeAlumnos

            // Cada decorador envuelve al anterior, Decorando asi el AlumnoBase
            IAlumno alumnoDecorado = new DecoPorLegajo(alumnoBase);
            alumnoDecorado = new DecoCalificacionLetras(alumnoDecorado);
            alumnoDecorado = new DecoPorNotaP(alumnoDecorado);
            alumnoDecorado = new DecoPorAsterisco(alumnoDecorado);

            //adapto el alumno decorado al tipo Student
            Student studentAdaptado = new AlumnoAdapter(alumnoDecorado); //Casteamos el alumnoDecorado con el AlumnoAdapter para que sea compatible com Student

            // Retorna el Student adaptado
            return (Comparable)studentAdaptado; // Casteamos para retornar un Comparable
        }

        // Este método crea un Student pidiendo datos por teclado
        public override Comparable crearPorTeclado()
        {
            
            AlumnoMuyEstudioso alumnoBase = (AlumnoMuyEstudioso)base.crearPorTeclado(); //Casteeamos al AlumnoEstudioso base dirigido de FabricaDeAlumnos

            // Cada decorador envuelve al anterior, Decorando asi el AlumnoBase
            IAlumno alumnoDecorado = new DecoPorLegajo(alumnoBase);
            alumnoDecorado = new DecoCalificacionLetras(alumnoDecorado);
            alumnoDecorado = new DecoPorNotaP(alumnoDecorado);
            alumnoDecorado = new DecoPorAsterisco(alumnoDecorado);

            //adapto el alumno decorado al tipo Student
            Student studentAdaptado = new AlumnoAdapter(alumnoDecorado);// Casteamos el alumnoDecorado con el AlumnoAdapter para que sea compatible com Student

            // Retorna el Student adaptado
            return (Comparable)studentAdaptado; // Casteamos para retornar un Comparable
        }
    }
}
