using System;
using System.Collections.Generic;

namespace Practica
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            int valor = GeneradorDeDatosAleatorios.numeroAleatorio(100);
            return new Numero(valor);
        }
        public override Comparable crearPorTeclado()
        {
            int valor = LectorDeDatos.numeroPorTeclado();
            return new Numero(valor);
        }

    }
}
