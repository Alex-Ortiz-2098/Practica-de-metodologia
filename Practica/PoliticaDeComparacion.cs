using System;
using System.Collections.Generic;

namespace Practica
{
    public interface PoliticaDeComparacion // decidi designar la responsabilidad de los tres metodos a la estrategia para evitar error o demasiados cambios
    {
        bool SosIgual(Comparable c1, Comparable c2);
        bool SosMenor(Comparable c1, Comparable c2);
        bool SosMayor(Comparable c1, Comparable c2);
    }

    public class PorNombre : PoliticaDeComparacion //POLITICA POR NOMBRE
    {
        public bool SosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }
        public bool SosMayor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) > 0;
        }

        public bool SosMenor(Comparable c1, Comparable c2)
        {
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) < 0;
         }
    }

    public class PorDni : PoliticaDeComparacion  //POLITICA POR DNI
    {
        public bool SosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() == ((Alumno)c2).getDNI();
        }
        public bool SosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() > ((Alumno)c2).getDNI();
        }
        public bool SosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getDNI() < ((Alumno)c2).getDNI();
         }
        
    }

    public class PorPromedio : PoliticaDeComparacion //POLITICA POR PROMEDIO
    {
        public bool SosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio();
        }
        public bool SosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
        }

        public bool SosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getPromedio() < ((Alumno)c2).getPromedio();
         }
    }

    public class PorLegajo : PoliticaDeComparacion //POLITICA POR LEGAJO
    {
        public bool SosIgual(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getlegajo() == ((Alumno)c2).getlegajo();
        }
        public bool SosMayor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getlegajo() > ((Alumno)c2).getlegajo();
        }

        public bool SosMenor(Comparable c1, Comparable c2)
        {
            return ((Alumno)c1).getlegajo() < ((Alumno)c2).getlegajo();
        }
    }
}
