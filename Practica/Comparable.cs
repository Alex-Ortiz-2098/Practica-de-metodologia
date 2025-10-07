using System;
namespace Practica
{
    public interface Comparable //Un contrato que debe ser implementado por quien lo herede
    {
        bool SosIgual(Comparable c);
        bool SosMenor(Comparable c);
        bool SosMayor(Comparable c);
    }
    
    //Comparable es una interfaz que define cómo se comparan dos objetos de un mismo tipo para establecer un orden.
}