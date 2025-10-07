using System;
using System.Collections.Generic;

namespace Practica
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }

}