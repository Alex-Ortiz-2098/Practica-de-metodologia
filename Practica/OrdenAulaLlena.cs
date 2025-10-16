using System;

namespace Practica
{
    public class OrdenAulaLlena: IOrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }
        public void Ejecutar()
        {
            aula.ClaseLista();
        }


    }
}