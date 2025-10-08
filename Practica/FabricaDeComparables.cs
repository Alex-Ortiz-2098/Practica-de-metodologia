using System;
using System.Collections.Generic;

namespace Practica
{
    public abstract class FabricaDeComparables
    {
        // los datos ingresados se crean una sola vez (por que son static) para minimizar el uso de memoria y la creacion de multiples generadores
        protected static GeneradorDeDatosAleatorios DatoAle = new GeneradorDeDatosAleatorios();
        protected static LectorDeDatos DatoTecla = new LectorDeDatos();
        public static Comparable crearAleatorio(int opcion) // Devuelve un Comparable generado aletoriamente
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeAlumnos();
                    break;

                case 2:
                    fabrica = new FabricaDeProfesores();
                    break;
                
                case 3:
                    fabrica = new FabricaDeNumeros();
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;

            }
            return fabrica.crearAleatorio();

        }
        public static Comparable crearPorTeclado(int opcion) //Devuelve un comparable donde los datos se ingresan por teclado
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1:
                    fabrica = new FabricaDeAlumnos();
                    break;

                case 2:
                    fabrica = new FabricaDeProfesores();
                    break;

                case 3:
                    fabrica = new FabricaDeNumeros();
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
     
            }
            return fabrica.crearPorTeclado();

        }

        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}