using System;
using System.Collections.Generic;

namespace Practica
{
    public class AlumnoMuyEstudioso : Alumno, IAlumnoMuyEstudioso
    {
        public AlumnoMuyEstudioso(string n, string a, int d, int l, int p) : base(n, a, d, l, p)
        {
        }
        
        public override int responderPregunta(int pregunta)
        //ESTA FUNCION LA CAMBIE PARA PODER DISTINGUIR ENTRE LAS CALIFICACIONES DE LOS ESTUDIANTES NORMALES y LOS ESTUDIOSOS
        {
            Random rand = new Random();

            // 90% de probabilidad de contestar correctamente
            if (rand.NextDouble() < 0.9)
                return pregunta % 3;
            else
                return rand.Next(0, 3); // otra respuesta aleatoria

        }    
    }
}