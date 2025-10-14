using System;
using System.Collections.Generic;

namespace Practica
{ 

    public class DecoCalificacionLetras : DecoradorAlumno
    {
        public DecoCalificacionLetras(IAlumno a) : base(a) { }

        private string CalificacionEnLetras(int cal)
        {
            switch(cal)
            {
                    case 0: return "CERO";
                    case 1: return "UNO";
                    case 2: return "DOS";
                    case 3: return "TRES";
                    case 4: return "CUATRO";
                    case 5: return "CINCO";
                    case 6: return "SEIS";
                    case 7: return "SIETE";
                    case 8: return "OCHO";
                    case 9: return "NUEVE";
                    case 10: return "DIEZ";
                    default: return "DESCONOCIDO";
            }
        }

        public override string mostrarCalificacion()
        {
            return alumno.getNombre() + " " + alumno.getApellido() + " (" + alumno.getlegajo() + ") " + alumno.getCalificacion() + "(" + CalificacionEnLetras(this.alumno.getCalificacion()) + ")";
        }
    }
}