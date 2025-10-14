using System;
namespace Practica
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            // Nombre, dni, legajo, Promedio
            return new AlumnoMuyEstudioso(DatoAle.stringAleatorio(10),DatoAle.stringAleatorio(10), DatoAle.numeroAleatorio(100000000), DatoAle.numeroAleatorio(1000), DatoAle.numeroAleatorio(10));
            // Cada llamada es independiente por ende se guarda el resultado sin interferir con la siguiente llamada
        }
        public override Comparable crearPorTeclado()
        {
            // Nombre, dni, legajo, Promedio
            return new AlumnoMuyEstudioso(DatoTecla.stringPorTeclado(),DatoTecla.stringPorTeclado(), DatoTecla.numeroPorTeclado(), DatoTecla.numeroPorTeclado(), DatoTecla.numeroPorTeclado());
            // Cada llamada es independiente por ende se guarda el resultado sin interferir con la siguiente llamada
        }
    }
}
