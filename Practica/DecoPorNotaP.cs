using System;
using System.Collections.Generic;

namespace Practica
{ 
    public class DecoPorNotaP : DecoradorAlumno
    {
        public DecoPorNotaP(IAlumno a) : base(a) { }

        public override string mostrarCalificacion()
        {
            if(alumno.getCalificacion() >= 7)
            {
                return alumno.getNombre()+" "+alumno.getApellido()+" ("+alumno.getlegajo()+") "+ alumno.getCalificacion()+"(PROMOCION)";

            }
            if(alumno.getCalificacion() >= 4 || alumno.getCalificacion() < 7)
            {
                return alumno.getNombre()+" "+alumno.getApellido()+" ("+alumno.getlegajo()+") "+ alumno.getCalificacion()+"(APROBADO)";
            }
            else
            {
                return alumno.getNombre()+" "+alumno.getApellido()+" ("+alumno.getlegajo()+") "+ alumno.getCalificacion()+"(DESAPROBADO)";
            }

        }

            
    }
}
