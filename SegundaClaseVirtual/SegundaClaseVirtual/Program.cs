using SegundaClaseVirtual.Domain;
using SegundaClaseVirtual.Service;

ProductService productService = new ProductService();
List<Product> lp = productService.GetProducts();


if (lp.Count > 0)
    foreach (Product p in lp)
    {
        Console.WriteLine(p);
    }
else
    Console.WriteLine("No hay productos...");