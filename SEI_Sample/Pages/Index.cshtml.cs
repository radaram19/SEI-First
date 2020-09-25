using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SEI_Sample.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Product> Products { get; set; }
        public void OnGet()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/api/");
                //HTTP GET
                var responseTask = client.GetAsync("product");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    var readTask = result.Content.ReadAsAsync<List<Product>>();
                    readTask.Wait();

                    Products = readTask.Result;

                   
                }
            }
        }
        public ActionResult OnGetView(int id)
        {
            return Partial("ProductDetail");
        }
        public ActionResult ProductDetail()
        {
            return Partial("ProductDetail");
        }

    }
}
