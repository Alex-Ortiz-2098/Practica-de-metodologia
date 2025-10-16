using System;

namespace Practica
{
    public class OrdenInicio: IOrdenEnAula1
    {
        private Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }
        public void Ejecutar()
        {
            aula.Comenzar();
        }


    }
}