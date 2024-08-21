using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductoInterface
{
    internal class Pack : Producto
    {
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Pack(int codigo, string nombre, double precio, int cantidad) : base(codigo, nombre, precio)
        {
            this.cantidad = cantidad;
        }

        public override double calcularPrecio(){ 
            return Precio * cantidad; 
        }

        
    }
}
