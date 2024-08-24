using SegundaClaseVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseVirtual.Data
{
    internal class ProductRepositoryADO : IProductRepository
    {

        private DataHelper _dataHelper;

        //Implementamos todos los metodos de la interface
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> getAll()
        {
            List <Product> lst = new List<Product>();

            //conectar a BD
            //traer registros      //todo esto en otra clase
            var dt =  DataHelper.GetInstance().ExecuteSPQuery("SP_Recuperar_Productos");

            //mapear 
            foreach (DataRow Row in dt.Rows) {
                Product p = new Product();
                p.Codigo = (int)Row["codigo"];
                p.Nombre = Row["n_producto"].ToString();
                p.Precio = (double)Row["precio"];
                p.Stock = (int)Row["stock"];
                p.Activo = (bool)Row["esta_activo"];
                lst.Add(p);
            }
            //desconectar la BD
            return lst;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
