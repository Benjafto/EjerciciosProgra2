using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEjercicioUno
{
    internal class Cola : iColeccion
    {
        List<object> elementos;
        public Cola()
        {
            elementos = new List<object>(); 
            
        }

        public bool añadir(object obj)
        {
            elementos.Add(obj);
            return true;
        }

        public bool estaVacia()
        {
            if (elementos.Count == 0) {return true;} else { return false;}  
        }

        public object extraer()
        {
            elementos.Remove(0);
            return true;
        }

        public object primero()
        {
            int tamaño = elementos.Count();
            return elementos[tamaño- 1];
        }
    }
}
