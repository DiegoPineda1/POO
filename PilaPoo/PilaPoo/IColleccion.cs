using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaPOO
{
    internal interface IColleccion
    {
        public abstract bool EstaVacia();
        public abstract object Extraer();
        public abstract object Primero();
        public abstract bool Añadir(object e);
    }
}
