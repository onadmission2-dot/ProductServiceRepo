using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductServiceDeployment.Models;

namespace ProductServiceDeployment.Operations
{
    public interface IProductOperation
    {
        public List<Product> GetAllProducts();
        int CreateProduct(Product product);
    }
    
       
}