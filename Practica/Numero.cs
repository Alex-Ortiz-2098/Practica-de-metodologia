using System;
using System.Collections.Generic;

namespace Practica
{
    public class Numero: Comparable  //hago que la clase número implemente la interfaz comparable
    {
        
        //atributos
        private int valor; //Es una variable que almacena un número entero

        //constructor
        public Numero(int val) 
        { 
            this.valor = val; 
        }

        //propiedades

        public int GetValor() 
        { 
            return this.valor; 
        }
      
      
      //métodos de la interfaz comparable (se utilizara si el comparable resulta ser un int)

       public bool SosIgual(Comparable otro) // Devuelve si es Igual atravez de un booleano
        {
            Numero otroNumero = (Numero)otro;  // casteo
            return this.valor == otroNumero.valor; 
        }

        public bool SosMenor(Comparable otro)// Devuelve si es Menor que el valor guardado
        {
            Numero otroNumero = (Numero)otro;
            return this.valor < otroNumero.valor;
        }

        public bool SosMayor(Comparable otro)// Devuelve si es Mayor que el valor guardado
        {
            Numero otroNumero = (Numero)otro;
            return this.valor > otroNumero.valor;
        }

        public override string ToString() //sirve para definir cómo se representa un objeto como texto
        {
            return valor.ToString();
        }
 
    }
}