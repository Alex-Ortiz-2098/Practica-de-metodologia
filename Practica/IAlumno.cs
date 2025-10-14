/* Tanto en Alumnos como en otras clases comence a utlizar IAlumno por las implementaciones dadas por decoreitor
Adapter, por lo cual implemente cambios de casteo en diferentes clases en donde ahora se castea en base
a IAlumno(INTERFACE ALUMNO) y ya no hacia Alumno*/

using System;

namespace Practica  
{
    public interface IAlumno : Comparable 
    {
        string getNombre();
        string getApellido();
        int getlegajo();
        int getDNI();
		int getPromedio();
        int getCalificacion();
        void setCalificacion(int cal);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();

        PoliticaDeComparacion POLITICA { get; set; }
    }
}