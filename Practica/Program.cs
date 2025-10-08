using System;
using System.Collections.Generic;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 7 (Practica 2)
            /*Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();
            llenarAlumnos(pila);
            llenarAlumnos(cola);
            llenarAlumnos(conjunto);
            ImprimirElementos(pila);
            ImprimirElementos(cola);
            ImprimirElementos(conjunto);*/

            // Ejercicio 9(Practica 2)
            Pila pila = new Pila();
            Llenar(pila,2);
            /*CambiarEstrategia(pila, new PorNombre());
            Informar(pila, 1);
            CambiarEstrategia(pila, new PorLegajo());
            Informar(pila, 1);
            CambiarEstrategia(pila, new PorDni());
            Informar(pila, 1);
            CambiarEstrategia(pila, new PorPromedio());*/
            Informar(pila, 2);



            Console.WriteLine("Hola, mundo!");
            Console.ReadKey();
        }

        public static void Llenar(Coleccionable cole, int opcion)
        {
            int i = 0;

            while (i < 20)
            {
                Comparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                cole.Agregar(comparable);
                i++;
            }
        }

        public static void Informar(Coleccionable c, int opcion)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Existe " + c.Cuantos()+ " Elementos");
            Console.WriteLine("El Menor Elemento es : " + c.Minimo());
            Console.WriteLine("El Mayor Elemento es: " + c.Maximo());
            Console.WriteLine("-------------------------------");
                Comparable com = FabricaDeComparables.crearPorTeclado(opcion); // escribo todo el comparable para luego buscarlo
                
                if (c.Contiene(com))
                {
                    Console.WriteLine("El Elemento esta en la lista");
                }
                else
                {
                    Console.WriteLine("El Elemento no esta en la lista");
                }

        }

        public static void ImprimirElementos(Coleccionable c)
        {
            Iterador ite = ((Iterable)c).crearIterador();

            ite.primero();

            while (!ite.fin())// Utilizo el while para recorrer de manera que se corte en el final
            {
                string actual = ite.actual().ToString();
                Console.WriteLine(actual);

                ite.siguiente();
            }

        }

        public static void CambiarEstrategia(Coleccionable c,PoliticaDeComparacion ite)
        {
            Iterador x = ((Iterable)c).crearIterador();// Casteo para asi crear el Iterador

            x.primero();

            while (!x.fin())// Utilizo el while para recorrer de manera que se corte en el final
            {
                Comparable elem = x.actual();// elem es Comparable
                if (elem is Alumno) // chequeo de tipo
                {
                    ((Alumno)elem).POLITICA = ite; // casteo seguro
                    x.siguiente();

                }                  
                   
            }
        }
        

    }
}