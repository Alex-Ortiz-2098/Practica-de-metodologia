using System;
using System.Collections.Generic;

namespace Practica
{

    public class DecoPorAsterisco : DecoradorAlumno
    {
        public DecoPorAsterisco(IAlumno a) : base(a) { }

        public override string mostrarCalificacion()
        {

            string texto = alumno.mostrarCalificacion();                
            int ancho = texto.Length + 4; // 2 espacios a cada lado
            string linea = new string('*', ancho);

            string resultado = linea + "\n";
            resultado += "* " + texto + " *\n";
            resultado += linea;

            return resultado;
        }
    }
}