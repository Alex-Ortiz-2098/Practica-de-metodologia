using System;
using System.Collections.Generic;

namespace Practica
{ 
    public class DecoPorLegajo : DecoradorAlumno
    {
        public DecoPorLegajo(IAlumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            return alumno.getNombre()+" "+alumno.getApellido()+" ("+alumno.getlegajo()+") "+ alumno.getCalificacion();
        }
    }
}

