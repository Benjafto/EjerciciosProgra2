using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductoInterface
{
    abstract class Producto : iPrecio
    {

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }





        public Producto(int codigo, string nombre, double precio)
        {
            this.codigo = codigo;
			this.nombre = nombre;
			this.precio = precio;	
        }


        public abstract double calcularPrecio();
        
    }
}
