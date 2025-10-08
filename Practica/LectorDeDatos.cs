using System;
using System.Collections.Generic;

namespace Practica
{
    public class LectorDeDatos // esta clase se Utiliza leyendo datos por teclado
    {
        public int numeroPorTeclado() // devuelve un número leído por teclado
        {
            Console.WriteLine("Ingrese un numero: ");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        public string stringPorTeclado() // devuelve un string leído por teclado
        {
            Console.WriteLine("Ingrese lo una palabra por teclado: ");
            string x = Console.ReadLine();
            return x;
        }
    }
}
