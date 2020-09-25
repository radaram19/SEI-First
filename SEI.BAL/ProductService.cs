using Microsoft.EntityFrameworkCore;
using SEI.API.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEI.BAL
{
    public class ProductService : IProductService
    {
        private  ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }
        public async  Task<List<Product>> GetProduct()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Product.FindAsync(id);
        }
    }
}
