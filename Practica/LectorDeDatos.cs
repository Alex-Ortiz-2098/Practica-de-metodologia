using System;
using System.Collections.Generic;

namespace Practica
{
    public class LectorDeDatos // esta clase se Utiliza leyendo datos por teclado
    {
        public static int numeroPorTeclado() // devuelve un número leído por teclado
        {
            Console.WriteLine("Ingrese un numero: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        public static string stringPorTeclado() // devuelve un string leído por teclado
        {
            Console.WriteLine("Ingrese lo deseado por teclado: ");
            string x = Console.ReadLine();
            return x;
        }
    }
}
