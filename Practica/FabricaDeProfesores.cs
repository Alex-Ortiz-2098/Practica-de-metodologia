using System;
using System.Collections.Generic;

namespace Practica
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            // Nombre, dni, Antiguedad
            return new Profesor(DatoAle.stringAleatorio(10), DatoAle.numeroAleatorio(100000000), DatoAle.numeroAleatorio(100));
            // Cada llamada es independiente por ende se guarda el resultado sin interferir con la siguiente llamada

        }

        public override Comparable crearPorTeclado()
        {
            // Nombre, dni, Antiguedad
            return new Profesor(DatoTecla.stringPorTeclado(), DatoTecla.numeroPorTeclado(), DatoTecla.numeroPorTeclado());
            // Cada llamada es independiente por ende se guarda el resultado sin interferir con la siguiente llamada
        }
    }
}
    
