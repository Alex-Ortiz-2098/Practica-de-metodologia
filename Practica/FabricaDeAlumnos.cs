using System;
using System.Collections.Generic;

namespace Practica
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            // Nombre, dni, legajo, Promedio
            string nombre = GeneradorDeDatosAleatorios.stringAleatorio(2);
            int dni = GeneradorDeDatosAleatorios.numeroAleatorio(100000000);
            int legajo = GeneradorDeDatosAleatorios.numeroAleatorio(1000);
            int promedio = GeneradorDeDatosAleatorios.numeroAleatorio(10);
            return new Alumno(nombre, dni, legajo, promedio);
        }

        public override Comparable crearPorTeclado()
        {
            // Nombre, dni, legajo, Promedio
            string nombre = LectorDeDatos.stringPorTeclado();
            int dni = LectorDeDatos.numeroPorTeclado();
            int legajo = LectorDeDatos.numeroPorTeclado();
            int promedio = LectorDeDatos.numeroPorTeclado();
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
