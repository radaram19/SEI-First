using SEI.API.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SEI.BAL
{
    public  interface IProductService
    {
        Task<List<Product>> GetProduct();
        Task<Product> GetProductById(int id);
    }
}
