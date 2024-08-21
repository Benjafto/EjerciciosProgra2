using InterfaceEjercicioUno;


//pruebas de pila
Pila pila = new Pila(5);

object elementoPrueba = new object();

Console.WriteLine(pila.estaVacia());
pila.añadir(elementoPrueba);
Console.WriteLine(pila.estaVacia());
pila.extraer();
Console.WriteLine(pila.estaVacia());

//pruebas de cola



