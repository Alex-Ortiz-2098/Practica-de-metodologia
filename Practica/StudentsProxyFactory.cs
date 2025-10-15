using System;
using System.Collections.Generic;

namespace Practica
{
    public class StudentsProxyFactory : FabricaDeComparables
    {
        private bool esEstudioso;

        public StudentsProxyFactory(bool estudioso = false)
        {
            this.esEstudioso = estudioso;
        }

        public override Comparable crearAleatorio()
        {
            // Aquí usamos un AlumnoProxy en lugar de un Alumno real
            IAlumno proxy = new AlumnoProxy(DatoAle.stringAleatorio(10), DatoAle.stringAleatorio(10), DatoAle.numeroAleatorio(100000000), DatoAle.numeroAleatorio(1000), DatoAle.numeroAleatorio(10));

            // Decoramos para su uso en student
            IAlumno alumnoDecorado = new DecoPorLegajo(proxy);
            alumnoDecorado = new DecoCalificacionLetras(alumnoDecorado);
            alumnoDecorado = new DecoPorNotaP(alumnoDecorado);
            alumnoDecorado = new DecoPorAsterisco(alumnoDecorado);

            // Lo adaptamos a Student
            Student studentAdaptado = new AlumnoAdapter(alumnoDecorado);

            return (Comparable)studentAdaptado;
        }

        public override Comparable crearPorTeclado()
        {
            // Aquí usamos un AlumnoProxy en lugar de un Alumno real
            IAlumno proxy = new AlumnoProxy(DatoTecla.stringPorTeclado(), DatoTecla.stringPorTeclado(), DatoTecla.numeroPorTeclado(), DatoTecla.numeroPorTeclado(), DatoTecla.numeroPorTeclado());
            
            // Decoramos para su uso en student
            IAlumno alumnoDecorado = new DecoPorLegajo(proxy);
            alumnoDecorado = new DecoCalificacionLetras(alumnoDecorado);
            alumnoDecorado = new DecoPorNotaP(alumnoDecorado);
            alumnoDecorado = new DecoPorAsterisco(alumnoDecorado);

            // Lo adaptamos a Student
            Student studentAdaptado = new AlumnoAdapter(alumnoDecorado);

            return (Comparable)studentAdaptado;



        }
    }
}