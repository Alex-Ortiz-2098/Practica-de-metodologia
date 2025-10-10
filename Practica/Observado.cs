using System;
using System.Collections.Generic;

namespace Practica
{
    public interface Observado
    {
        void AgregarObservador(Observador o); // Agrega a la lista a los obvservados
        void QuitarObservador(Observador o); // Elimina de la lista a los obvservados
        void Notificar(); // notifica a todos los observadores
    }
}