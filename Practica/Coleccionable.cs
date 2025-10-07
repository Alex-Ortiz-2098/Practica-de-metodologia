using System;
namespace Practica
{
    public interface Coleccionable
    {
        int Cuantos();//Devuelve la cantidad de elementos comparables que tiene el coleccionable
        Comparable Minimo(); //Devuelve el elemento minimo del coleccionable
        Comparable Maximo(); //Devuelve el elemento maximo del coleccionable
        void Agregar(Comparable c); //Agrega un elemento comparable al coleccionable
        bool Contiene(Comparable c); //Devuelve true si el elemento comparable c esta en el coleccionable, false caso contrario
    }
}
