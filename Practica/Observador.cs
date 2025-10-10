using System;
using System.Collections.Generic;

namespace Practica
{
    public interface Observador
    {
        void Actualizar(Observado o); // recibe un mensaje o tipo de evento del profesor
    }
}