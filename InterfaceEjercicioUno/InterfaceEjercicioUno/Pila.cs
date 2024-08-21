using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEjercicioUno
{
    public class Pila : iColeccion
    {
        int tamaño;
        object[] elementos;
        int contador = 0;
        public Pila(int tamaño)
        {
            this.tamaño = tamaño;
            elementos = new object[tamaño];
            int contador = 0; 
        }

        public bool añadir(object obj)
        {

            if (contador < tamaño) {
                elementos[contador] = obj;
                contador += 1;
                return true;
            } else { return false; }
        } 
                
           
        public bool estaVacia()
        {
                if(contador == 0) { return true; } else {return false;} 
        }

        public object extraer()
        {
            object extraido = elementos[contador];
            elementos[contador] = null;
            contador -= 1;
            return extraido;
        }

        public object primero()
        {
            return elementos[contador];
        }

    }



        
    }
