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

        public void Extraer()
        {
            throw new NotImplementedException();
        }

        public object Primero()
        {
            throw new NotImplementedException();
        }
    }
}
