using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProductoInterface
{
    internal class Suelto : Producto
    {

		private double medida;

		public double Medida
		{
			get { return medida; }
			set { medida = value; }
		}

        public Suelto(int codigo, string nombre, double precio, double medida) : base(codigo, nombre, precio)
        {
            this.medida = medida;
        }

        public override double calcularPrecio()
        {
            return medida * Precio;
        }

    }
}
