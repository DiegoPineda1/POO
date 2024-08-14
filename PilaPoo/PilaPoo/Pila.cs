using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaPOO
{
    internal class Pila : IColleccion
    {
        public List<object> pila;
        private int tamaño = 0;

        public Pila()
        {
            pila = new List<object>();
        }

        public bool Añadir(object elemento)
        {
            try
            {
                pila.Add(elemento);
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool EstaVacia()
        {
            bool aux = false;
            if(pila.Count == 0)
            {
                aux = true;
            }

            return aux;
        }

        public object Extraer()
        {
            if (pila.Count == 0)
                return null;

            object elemento = pila[pila.Count - 1];
            pila.RemoveAt(pila.Count - 1);
            return elemento;

        }

        public object Primero()
        {
            if (pila.Count == 0)
                return null;

            object elemento = pila[0];
            return elemento;
        }
    }
}
