using System;
using System.Collections.Generic;

namespace Practica
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(DatoAle.numeroAleatorio(100));
        }
        public override Comparable crearPorTeclado()
        {
            return new Numero(DatoTecla.numeroPorTeclado());
        }

    }
}
