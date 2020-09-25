using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEI.API.DAL;

namespace SEI.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductContext productContext;

        public ProductController(ProductContext pc)
        {
            productContext = pc;
        }

        /// <summary>
        /// Get all products order by AverageCustomerRating
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var products = productContext.Product.ToList().OrderByDescending(a=>a.AverageCustomerRating);
            if (products == null)
            {
                return BadRequest("Product doesn't exist");
            }
            return Ok(products);
        }

        /// <summary>
        /// Get Product detail by productid
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        [HttpGet("{pid}")]
        public IActionResult Get(int pid)
        {
            Product product = productContext.Product.FirstOrDefault(a=>a.ProductId== pid);
            if (product == null)
            {
                return BadRequest("Product doesn't exist");
            }
            return Ok(product);
        }

        
    }
}
