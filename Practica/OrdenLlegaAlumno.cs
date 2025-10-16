using System;

namespace Practica
{
    public class OrdenLlegaAlumno: IOrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }
        public void Ejecutar(Comparable c)
        {
            Alumno alumno = (Alumno)c;
            aula.NuevoAlumno(alumno);
        }


    }
}