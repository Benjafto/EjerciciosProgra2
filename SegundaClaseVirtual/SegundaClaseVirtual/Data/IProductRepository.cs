using SegundaClaseVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseVirtual.Data
{
    public interface IProductRepository
    {
        List<Product> getAll(); // Carga una lista de producots con los productos obtenidos
        Product GetById(int id); //Busca un producto y devuelve un objeto de tipo producto
        bool Save(Product product); // necesitamos el objeto entero cargado para poder guardarlo
        bool Delete(int id); //para Buscar y borrar solo necesitamos un id para identificar
    }
}
