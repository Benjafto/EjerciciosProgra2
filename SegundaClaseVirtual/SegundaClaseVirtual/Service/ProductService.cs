using SegundaClaseVirtual.Data;
using SegundaClaseVirtual.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClaseVirtual.Service
{
    public class ProductService
    {

        private IProductRepository _repository;

        public ProductService()
        {
            _repository = new ProductRepositoryADO();
        }
        public List<Product> GetProducts()
        {
            return _repository.getAll();
        }
    }
}
