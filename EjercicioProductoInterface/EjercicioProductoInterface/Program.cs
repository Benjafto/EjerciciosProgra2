// See https://aka.ms/new-console-template for more information
using EjercicioProductoInterface;
using System.IO.Pipes;

Pack paquete = new Pack(123, "sixPack", 12000, 10);

Console.WriteLine(paquete.calcularPrecio());


Suelto suelto = new Suelto (555, "lata", 2200, 550.50);

Console.WriteLine(suelto.calcularPrecio());
