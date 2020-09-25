using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SEI_Sample.Pages
{
    public class ProductDetailModel : PageModel
    {
        public Product ProductInfo { get; set; }
        public void OnGet(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                //HTTP GET
                var responseTask = client.GetAsync("product/"+id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<Product>();
                    readTask.Wait();

                    ProductInfo = readTask.Result;
                }
            }
        }
    }
}
